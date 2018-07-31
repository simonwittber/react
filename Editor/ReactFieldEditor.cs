using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using UnityEngine;
using UnityEditor;
using DifferentMethods.React;
using UnityEditorInternal;

namespace DifferentMethods.React.Editor
{

    public class ReactFieldEditor
    {

        static Dictionary<System.Type, string[]> _typeCache = new Dictionary<System.Type, string[]>();

        public static void DrawFields(BaseNode node, bool focus, bool active)
        {
            var fields = ReactTypeRegister.GetFields(node);

            foreach (var f in fields)
            {
                if (f.IsStatic)
                    continue;
                if (f.Name == "enabled")
                    continue;
                if (f.Name == "Reactor")
                    continue;
                if (focus) GUI.SetNextControlName("FirstFocus");
                if (active)
                    DrawFieldEditor(f, node);
                else
                    DrawFieldLabels(f, node);
            }
            if (node is SuperNode)
                node.rect.height *= 2;
        }

        protected static System.Type TypePopup<T>(System.Type type)
        {
            string[] types;
            if (!_typeCache.TryGetValue(typeof(T), out types))
            {
                types = (from a in System.AppDomain.CurrentDomain.GetAssemblies()
                         from t in a.GetTypes()
                         where t.IsSubclassOf(typeof(T))
                         select t.FullName).ToArray();
                _typeCache[typeof(T)] = types;
            }
            var index = type == null ? 0 : System.Array.IndexOf(types, type.FullName);
            index = EditorGUILayout.Popup(index, types);
            return System.Type.GetType(types[index]);
        }

        static void DrawStringTypeFields(Rect rect, FieldInfo f, object obj)
        {
            var node = (BaseNode)obj;
            if (f.Name == "tag")
            {
                f.SetValue(node, EditorGUI.TagField(rect, (string)f.GetValue(node)));
            }
            else if (f.Name == "label")
            {
                var labels = ReactEditor.labels.ToArray();
                var name = (string)f.GetValue(node);
                var index = System.Array.IndexOf(labels, name);

                if (labels.Length == 0)
                {
                    GUI.Label(rect, "[No Labels]");
                }
                else
                {
                    index = Mathf.Clamp(index, 0, labels.Length);
                    index = EditorGUI.Popup(rect, index, labels);
                    f.SetValue(node, labels[index]);
                }
            }
            else
            {
                f.SetValue(node, EditorGUI.TextField(rect, (string)f.GetValue(node)));
            }
            //Validate eventName fields.
            if (f.Name == "eventName")
            {
                f.SetValue(node, f.GetValue(node).ToString().Replace(" ", "_").ToUpper());
            }

        }

        static void DrawFieldLabels(FieldInfo fi, object obj)
        {

            if (obj is UnityEngine.Object)
            {
                if (fi.Name == "nodeParent") return;
                if (fi.Name == "Child") return;
            }

            var node = (BaseNode)obj;
            var rect = node.rect;
            rect.x += rect.width;

            var label = new GUIContent(fi.Name);

            rect.width = EditorStyles.miniBoldLabel.CalcSize(label).x;
            node.rect.width += rect.width + 5;
            //DRAW LABELS FOR FIELDS
            GUI.color = Color.white;
            GUI.Label(rect, label, EditorStyles.miniBoldLabel);
            rect.x += rect.width + 5;
            rect.y += 4;
            rect.height = 16;
            //DRAW WIDGETS FOR FIELDS
            GUI.color = Color.white;
            GUI.contentColor = Color.white;

            var value = fi.GetValue(obj);

            if (fi.FieldType == typeof(float))
            {
                rect.width = 32;
                GUI.Label(rect, value.ToString());
            }
            else if (fi.FieldType == typeof(int))
            {
                rect.width = 32;
                GUI.Label(rect, value.ToString());
            }
            else if (fi.FieldType == typeof(string))
            {
                rect.width = 96;
                GUI.Label(rect, value == null ? "" : value.ToString());
            }
            else if (fi.FieldType == typeof(bool))
            {
                rect.width = 32;
                GUI.Label(rect, value.ToString());
            }
            else if (fi.FieldType.IsSubclassOf(typeof(System.Enum)))
            {
                rect.width = 96;
                GUI.Label(rect, value.ToString());
            }
            else if (fi.FieldType == typeof(Vector3))
            {
                rect.width = 196;
                GUI.Label(rect, value.ToString());
            }
            else if (fi.FieldType == typeof(Vector2))
            {
                rect.width = 196 * 0.6666666f;
                GUI.Label(rect, value.ToString());
            }
            else if (fi.FieldType == typeof(Vector4))
            {
                rect.width = 196 * 1.3333333f;
                GUI.Label(rect, value.ToString());
            }
            else if (fi.FieldType == typeof(Color))
            {
                rect.width = 48;
                EditorGUI.ColorField(rect, GUIContent.none, (Color)value);
            }
            else if (fi.FieldType == typeof(string[]))
            {
                rect.width = 96;
                GUI.Label(rect, "[values]");
            }
            else if (fi.FieldType == typeof(LayerMask))
            {
                rect.width = 96;
                LayerMaskField(rect, (LayerMask)value);
            }
            else if (fi.FieldType.IsSubclassOf(typeof(UnityEngine.Object)))
            {
                rect.width = 96;
                var uo = (UnityEngine.Object)value;
                if (uo == null)
                    GUI.Label(rect, "None");
                else
                    GUI.Label(rect, uo.ToString());
            }
            else
            {
                rect.width = 96;
                GUI.Label(rect, string.Format("[{0}]", fi.FieldType));
            }

            node.rect.width += rect.width + 5;
        }

        static void DrawFieldEditor(FieldInfo fi, object obj)
        {

            if (obj is UnityEngine.Object)
            {
                if (fi.Name == "nodeParent") return;
                if (fi.Name == "Child") return;
            }

            var node = (BaseNode)obj;
            var rect = node.rect;
            rect.x += rect.width;

            var label = new GUIContent(fi.Name);

            rect.width = EditorStyles.miniBoldLabel.CalcSize(label).x;
            node.rect.width += rect.width + 5;
            //DRAW LABELS FOR FIELDS
            GUI.color = Color.white;
            GUI.Label(rect, label, EditorStyles.miniBoldLabel);
            rect.x += rect.width + 5;
            rect.y += 4;
            rect.height = 16;
            //DRAW WIDGETS FOR FIELDS
            GUI.color = Color.white;
            GUI.contentColor = Color.white;
            EditorGUI.BeginChangeCheck();
            if (fi.FieldType == typeof(float))
            {
                rect.width = 32;
                fi.SetValue(obj, EditorGUI.FloatField(rect, (float)fi.GetValue(obj)));
            }
            else if (fi.FieldType == typeof(int))
            {
                rect.width = 32;
                fi.SetValue(obj, EditorGUI.IntField(rect, (int)fi.GetValue(obj)));
            }
            else if (fi.FieldType == typeof(string))
            {
                rect.width = 96;
                DrawStringTypeFields(rect, fi, obj);
            }
            else if (fi.FieldType == typeof(bool))
            {
                rect.width = 32;
                fi.SetValue(obj, EditorGUI.Toggle(rect, (bool)fi.GetValue(obj)));
            }
            else if (fi.FieldType.IsSubclassOf(typeof(System.Enum)))
            {
                rect.width = 96;
                fi.SetValue(obj, EditorGUI.EnumPopup(rect, (System.Enum)fi.GetValue(obj)));
            }
            else if (fi.FieldType == typeof(Vector3))
            {
                rect.width = 196;
                fi.SetValue(obj, (Vector3)EditorGUI.Vector3Field(rect, GUIContent.none, (Vector3)fi.GetValue(obj)));
            }
            else if (fi.FieldType == typeof(Vector2))
            {
                rect.width = 196 * 0.6666666f;
                fi.SetValue(obj, (Vector2)EditorGUI.Vector2Field(rect, GUIContent.none, (Vector2)fi.GetValue(obj)));
            }
            else if (fi.FieldType == typeof(Vector4))
            {
                rect.width = 196 * 1.3333333f;
                fi.SetValue(obj, (Vector4)EditorGUI.Vector4Field(rect, GUIContent.none, (Vector4)fi.GetValue(obj)));
            }
            else if (fi.FieldType == typeof(Color))
            {
                rect.width = 48;
                fi.SetValue(obj, (Color)EditorGUI.ColorField(rect, GUIContent.none, (Color)fi.GetValue(obj)));
            }
            else if (fi.FieldType == typeof(string[]))
            {
                rect.width = 96;
                DrawStringArrayField(fi, obj);
            }
            else if (fi.FieldType == typeof(LayerMask))
            {
                rect.width = 96;
                fi.SetValue(obj, LayerMaskField(rect, (LayerMask)fi.GetValue(obj)));
            }
            else if (fi.FieldType.IsSubclassOf(typeof(UnityEngine.Object)))
            {
                rect.width = 96;
                fi.SetValue(obj, EditorGUI.ObjectField(rect, GUIContent.none, (UnityEngine.Object)fi.GetValue(obj), fi.FieldType, true));
            }
            else
            {
                rect.width = 96;
                GUI.Label(rect, string.Format("[{0}]", fi.FieldType));
            }
            if (EditorGUI.EndChangeCheck())
            {

            }
            node.rect.width += rect.width + 5;
        }

        static void DrawStringArrayField(FieldInfo f, object obj)
        {
            GUILayout.BeginVertical(GUILayout.MinWidth(72));
            var elements = (string[])f.GetValue(obj);
            if (elements == null)
                elements = new string[0];
            var killIndex = -1;
            for (int i = 0; i < elements.Length; i++)
            {
                var e = elements[i] ?? "";
                GUILayout.BeginHorizontal();
                elements[i] = GUILayout.TextField(e);
                if (GUILayout.Button(GUIContent.none, GUILayout.Width(16)))
                {
                    killIndex = i;
                }
                GUILayout.EndHorizontal();
            }
            if (killIndex >= 0)
            {
                elements = (from i in Enumerable.Range(0, elements.Length)
                            where i != killIndex
                            select elements[i]).ToArray();
            }
            if (GUILayout.Button("Add"))
            {
                System.Array.Resize(ref elements, elements.Length + 1);
            }
            GUILayout.EndVertical();
            f.SetValue(obj, elements);
        }


        static List<int> layerNumbers = new List<int>();

        public static LayerMask LayerMaskField(Rect rect, LayerMask layerMask)
        {
            var layers = InternalEditorUtility.layers;

            layerNumbers.Clear();

            for (int i = 0; i < layers.Length; i++)
                layerNumbers.Add(LayerMask.NameToLayer(layers[i]));

            int maskWithoutEmpty = 0;
            for (int i = 0; i < layerNumbers.Count; i++)
            {
                if (((1 << layerNumbers[i]) & layerMask.value) > 0)
                    maskWithoutEmpty |= (1 << i);
            }

            maskWithoutEmpty = EditorGUI.MaskField(rect, GUIContent.none, maskWithoutEmpty, layers);

            int mask = 0;
            for (int i = 0; i < layerNumbers.Count; i++)
            {
                if ((maskWithoutEmpty & (1 << i)) != 0)
                    mask |= (1 << layerNumbers[i]);
            }
            layerMask.value = mask;

            return layerMask;
        }


    }
}