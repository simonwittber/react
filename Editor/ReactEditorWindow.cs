using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using DifferentMethods.React.Components;

namespace DifferentMethods.React.Editor
{
    public class ReactEditorWindow : EditorWindow
    {
        ReactEditor _editor;

        Vector2 scroll;

        void OnEnable()
        {
            titleContent = new GUIContent("React Editor", EditorGUIUtility.Load("React/ReactIcon.png") as Texture2D);
        }

        void OnDestroy()
        {
            if (_editor != null) DestroyImmediate(_editor);
        }

        void Update()
        {
            if (Application.isPlaying || focusedWindow == this)
                Repaint();
        }

        ReactEditor CreateSaneEditor()
        {
            Reactor reactor = null;
            //First, try and load reactor from selected game object.
            if (Selection.activeGameObject != null)
                reactor = Selection.activeGameObject.GetComponent<Reactor>();
            //Debug.Log(reactor);
            //If the reactor is not maximised, don't draw it as it is drawn in the inspector.
            if (reactor == null || !reactor.goLarge) return null;
            //If the editor exists but it's  target is destroyed (coming back from playmode) destroy it.
            if (_editor != null && _editor.target == null)
                DestroyImmediate(_editor);
            //If the editor has not been created, create it with the active reactor.
            if (_editor == null)
                _editor = UnityEditor.Editor.CreateEditor(reactor) as ReactEditor;
            if (_editor.target != reactor)
            {
                DestroyImmediate(_editor);
                _editor = UnityEditor.Editor.CreateEditor(reactor) as ReactEditor;
            }

            return _editor;
        }

        void OnGUI()
        {
            var editor = CreateSaneEditor();
            if (editor == null) return;

            if (Event.current.isMouse && Event.current.button == 2)
            {
                scroll -= Event.current.delta;
            }
            editor.cullRect.xMin = scroll.x;
            editor.cullRect.xMax = scroll.x + EditorGUIUtility.currentViewWidth;
            editor.cullRect.yMin = scroll.y;
            editor.cullRect.yMax = scroll.y + position.height;
            using (var sc = new EditorGUILayout.ScrollViewScope(scroll))
            {
                editor.OnGUI();
                scroll = sc.scrollPosition;

            }
            //Repaint();
        }
    }
}