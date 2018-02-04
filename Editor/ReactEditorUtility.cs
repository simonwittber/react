using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Reflection;
using System.Linq;
using System.IO;
using System.Text;
using UnityEditor.Callbacks;
using System.Runtime.Serialization.Formatters;
using System.Xml.Serialization;
using System;
using System.Runtime.Serialization.Formatters.Binary;

namespace DifferentMethods.React.Editor
{

    public static class ReactEditorUtility
    {
        public static string LoadTemplate(string name)
        {
            try
            {
                return AssetDatabase.LoadAssetAtPath<TextAsset>(AssetDatabase.GUIDToAssetPath(AssetDatabase.FindAssets(string.Format("t:TextAsset {0}", name))[0])).text;
            }
            catch (IndexOutOfRangeException)
            {
                Debug.LogError("Missing Template: " + name);
                return null;
            }
        }

        public static string NiceName(string s)
        {
            var n = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (n.Length > 0 && char.IsUpper(s[i]) && (!char.IsUpper(n.Last())))
                {
                    n += " ";
                }
                n += (i == 0 ? s[i].ToString().ToUpper() : s[i].ToString());
            }
            return n;
        }

        public static void DrawLine(Vector2 C, Vector2 D, params Color[] colors)
        {
            var bc = Handles.color;
            foreach (var color in colors)
            {
                Handles.color = color;
                Handles.DrawPolyLine(C, D);
            }
            Handles.color = bc;
        }

        public static void DrawBackground(Rect rect, GUIStyle style)
        {
            GUI.Box(rect, GUIContent.none, style);
        }

        public static void DrawOutline(Rect rect, Color c, Color bg, int offset = 0)
        {
            var A = new Vector2(rect.xMin - (offset + 1), rect.yMin - offset);
            var B = new Vector2(rect.xMin - (offset + 1), rect.yMax + (offset + 1));
            var C = new Vector2(rect.xMax + offset, rect.yMax + (offset + 1));
            var D = new Vector2(rect.xMax + offset, rect.yMin - offset);
            var hc = Handles.color;
            Handles.color = c;
            Handles.DrawPolyLine(A, B, C, D, A);
            Handles.DrawSolidRectangleWithOutline(rect, bg, c);
            Handles.color = hc;
        }


    }

}