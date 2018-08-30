using System;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

namespace DifferentMethods.React.Editor
{
    [System.Serializable]
    public class GameObjectListSerializableObject : ScriptableObject, IDisposable
    {
        public GameObjectList gameObjectList;

        SerializedObject serializedObject;

        public static GameObjectListSerializableObject Create(GameObjectList list)
        {
            var obj = ScriptableObject.CreateInstance<GameObjectListSerializableObject>();
            obj.gameObjectList = list;
            obj.serializedObject = new SerializedObject(obj);
            return obj;
        }

        public SerializedProperty Property
        {
            get
            {
                return serializedObject.FindProperty("gameObjectList");
            }
        }

        public void Dispose()
        {
            serializedObject.ApplyModifiedProperties();
            serializedObject.Dispose();
            GameObject.DestroyImmediate(this);
        }
    }

    [CustomPropertyDrawer(typeof(GameObjectList))]
    public class GameObjectListDrawer : PropertyDrawer
    {
        [NonSerialized] ReorderableList list = null;
        [NonSerialized] SerializedProperty listProperty;
        [NonSerialized] GUIContent label;

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return 48 + property.FindPropertyRelative("items").arraySize * EditorGUIUtility.singleLineHeight;
        }

        public override void OnGUI(UnityEngine.Rect position, SerializedProperty property, UnityEngine.GUIContent label)
        {
            if (list == null)
            {
                this.label = label;
                this.listProperty = property.FindPropertyRelative("items");
                this.list = new ReorderableList(property.serializedObject, listProperty);
                list.drawElementCallback = DrawListElement;
                list.drawHeaderCallback = DrawHeader;
            }
            list.DoList(position);
        }

        private void DrawHeader(Rect rect)
        {
            EditorGUI.LabelField(rect, label);
        }

        void DrawListElement(Rect rect, int index, bool isActive, bool isFocused)
        {
            var r = new Rect(rect.x, rect.y + 2, rect.width - 20, EditorGUIUtility.singleLineHeight);
            EditorGUI.PropertyField(r, listProperty.GetArrayElementAtIndex(index), GUIContent.none);
        }


    }
}