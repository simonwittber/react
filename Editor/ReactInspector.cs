using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using DifferentMethods.React.Components;

namespace DifferentMethods.React.Editor
{

    [CustomEditor(typeof(Reactor), true)]
    public partial class ReactEditor : UnityEditor.Editor
    {
        Rect position;
        internal Reactor reactor;

        public override bool RequiresConstantRepaint()
        {
            return Application.isPlaying;
        }

        public override void OnInspectorGUI()
        {
            //base.OnInspectorGUI();
            reactor = target as Reactor;
            if (reactor.goLarge)
            {
                GUILayout.BeginHorizontal();
                if (GUILayout.Button("Open Editor"))
                {
                    var w = EditorWindow.GetWindow<ReactEditorWindow>();
                    w.Show();
                }
                GUILayout.Space(8);
                if (GUILayout.Button("Close Editor"))
                {
                    reactor.goLarge = false;
                }
                GUILayout.EndHorizontal();
            }
            else
            {
                cullRect = new Rect(0, 0, float.MaxValue, float.MaxValue);
                OnGUI();
            }
        }

    }
}