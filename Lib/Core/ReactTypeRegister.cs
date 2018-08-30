using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;
using DifferentMethods.Extensions;

namespace DifferentMethods.React
{
    public class SearchableReactNode
    {
        public System.Type type;
        public string menuPath;
        public string niceName;
        public string signature;
        public Assembly assembly;

    }
    public class ReactNodeType : SearchableReactNode
    {

    }

    public static class ReactTypeRegister
    {
        static Dictionary<System.Type, List<ReactNodeType>> typeMap;


        public static int RegisterNodeClass(System.Type wrappedType, System.Type type)
        {
            if (typeMap == null)
                typeMap = new Dictionary<Type, List<ReactNodeType>>(1024);


            List<ReactNodeType> clist;
            if (!typeMap.TryGetValue(wrappedType, out clist))
                typeMap[wrappedType] = clist = new List<ReactNodeType>();
            var rnt = new ReactNodeType()
            {
                type = type,
                menuPath = GetMenuPath(type),
                niceName = GetNiceName(type),
                signature = GetSignature(type)
            };
            clist.Add(rnt);
            return type.GetHashCode();
        }

        public static List<ReactNodeType> nodeTypes = new List<ReactNodeType>();

        public static Type Find(string className)
        {
            foreach (var t in AllTypes)
            {
                if (t.type.AssemblyQualifiedName == className) return t.type;
                if (t.type.FullName == className) return t.type;
                if (t.type.Name == className) return t.type;
                var commaIndex = className.IndexOf(',');
                if (commaIndex > 0)
                {
                    var classOnly = className.Substring(0, commaIndex);
                    if (t.type.AssemblyQualifiedName.Contains(classOnly)) return t.type;
                }
            }
            return null;
        }

        public static IEnumerable<ReactNodeType> ForType(System.Type type)
        {
            if (typeMap != null)
            {
                List<ReactNodeType> clist;
                if (typeMap.TryGetValue(type, out clist))
                    foreach (var cc in clist) yield return cc;
            }
        }


        public static List<ReactNodeType> AllTypes
        {
            get
            {
                if (nodeTypes.Count == 0)
                {
                    CollectTypes();
                }
                return nodeTypes;
            }
        }

        public static List<ReactNodeType> CoreTypes
        {
            get
            {
                if (nodeTypes.Count == 0)
                {
                    CollectTypes();
                }
                return (from i in nodeTypes
                        where IsCoreNode(i.type)
                        select i).ToList();
            }
        }

        public static List<ReactNodeType> CoreDecoratorTypes
        {
            get
            {
                if (nodeTypes.Count == 0)
                {
                    CollectTypes();
                }
                return (from i in nodeTypes
                        where IsCoreDecorator(i.type)
                        select i).ToList();
            }
        }

        public static List<ReactNodeType> ExtendedTypes
        {
            get
            {
                if (nodeTypes.Count == 0)
                {
                    CollectTypes();
                }
                return (from i in nodeTypes
                        where IsExtendedType(i.type)
                        select i).ToList();
            }
        }


        public static bool IsCoreDecorator(System.Type type)
        {
            return type.GetCustomAttributes(typeof(CoreDecoratorAttribute), true).Length > 0;
        }

        public static bool IsCoreNode(System.Type type)
        {
            return type.GetCustomAttributes(typeof(CoreNodeAttribute), true).Length > 0;
        }

        public static bool IsExtendedType(System.Type type)
        {
            return !IsCoreNode(type) && !IsCoreDecorator(type);
        }

        public static void CollectTypes()
        {
            nodeTypes.Clear();

            nodeTypes.AddRange(
                from a in AppDomain.CurrentDomain.GetAssemblies()
                from t in a.GetTypes()
                where (t.IsSubclassOf(typeof(DecoratorNode)) || t.IsSubclassOf(typeof(BranchNode)) || t.IsSubclassOf(typeof(LeafNode)))
                orderby GetMenuPath(t)
                select new ReactNodeType()
                {
                    type = t,
                    menuPath = GetMenuPath(t),
                    niceName = GetNiceName(t),
                    signature = GetSignature(t)
                }
            );

        }

        static string GetSignature(System.Type type)
        {
            var mi = type.GetMethod("Signature");
            if (mi == null || !mi.IsStatic)
            {
                return "";
            }
            else
            {
                return (string)mi.Invoke(null, null);
            }
        }

        static string GetNiceName(System.Type type)
        {
            var mi = type.GetMethod("NiceName");
            if (mi == null || !mi.IsStatic)
            {
                return type.Name;
            }
            else
            {
                return (string)mi.Invoke(null, null);
            }
        }

        static string GetMenuPath(System.Type type)
        {
            var mi = type.GetMethod("GetMenuPath");
            if (mi == null || !mi.IsStatic)
            {
                return type.Name;
            }
            else
            {
                return (string)mi.Invoke(null, null);
            }
        }

        public static bool IsSupportedMethod(MethodInfo m)
        {
            if (m.GetCustomAttributes(typeof(ObsoleteAttribute), true).Length > 0)
                return false;
            if (m.ContainsGenericParameters)
                return false;
            if (m.IsSpecialName)
                return false;
            if (!m.IsPublic)
                return false;
            if (System.Array.IndexOf(excludedNames, m.Name) != -1)
                return false;
            var parametersOK = true;
            foreach (var p in m.GetParameters())
            {
                if (m.DeclaringType == typeof(GameObjectPool))
                {


                }
                if (IsSupportedParameter(p.ParameterType))
                    continue;
                if (m.DeclaringType == typeof(GameObjectPool))
                {
                    //Debug.Log(m);
                }
                parametersOK = false;
            }
            return parametersOK;
        }

        public static bool IsSupportedParameter(Type t)
        {
            if (t == typeof(string))
                return true;
            if (t == typeof(int))
                return true;
            if (t == typeof(bool))
                return true;
            if (t == typeof(float))
                return true;
            if (t == typeof(Vector3))
                return true;
            if (t == typeof(Vector2))
                return true;
            if (t == typeof(Vector4))
                return true;
            if (t == typeof(Color))
                return true;
            if (t.IsEnum)
                return true;
            if (t == typeof(LayerMask))
                return true;
            if (t.IsSubclassOf(typeof(UnityEngine.Object)))
                return true;
            if (t == typeof(GameObject))
                return true;
            if (t == typeof(GameObjectList))
                return true;

            return false;
        }

        static Dictionary<System.Type, List<FieldInfo>> finfos;

        public static List<FieldInfo> GetFields(BaseNode node)
        {

            if (finfos == null)
                finfos = new Dictionary<System.Type, List<FieldInfo>>();
            var T = node.GetType();
            List<FieldInfo> fields;
            if (finfos.TryGetValue(T, out fields))
            {
                return fields;
            }
            fields = (from i in T.GetFields()
                      where (
                          i.IsPublic &&
                          ReactTypeRegister.IsSupportedParameter(i.FieldType))
                      select i).ToList();
            finfos[T] = fields;
            return fields;
        }

        public static string ShortTypeName(Type type)
        {
            var name = type.Name;
            switch (name)
            {
                case "Single":
                    return "float";
                case "String":
                    return "string";
                case "Int32":
                    return "int";
                case "Boolean":
                    return "bool";
                default:
                    return type.FullName.Replace("+", ".");
            }
        }

        public static string GetParameters(BaseNode node)
        {
            var parms = "";

            foreach (var fi in GetFields(node))
            {
                if (fi.FieldType.IsSubclassOf(typeof(UnityEngine.Object)))
                {
                    continue;
                }
                var value = fi.GetValue(node);
                {
                    parms += fi.Name + "=" + Repr(value) + ",";
                }
            }
            return parms;
        }

        public static string Repr(object o)
        {
            if (o is string)
            {
                return ("\"" + o.ToString() + "\"");
            }
            else if (o is float)
            {
                return (o.ToString() + "f");
            }
            else if (o is bool)
            {
                return (bool)o ? "true" : "false";
            }
            else if (o is System.Enum)
            {
                return string.Format("{0}.{1}", o.GetType().FullName, o.ToString());
            }
            else if (o is Vector3)
            {
                var v = (Vector3)o;
                return string.Format("new Vector3({0}f, {1}f, {2}f)", v.x, v.y, v.z);
            }
            else if (o is Vector2)
            {
                var v = (Vector2)o;
                return string.Format("new Vector2({0}f, {1}f, {2}f)", v.x, v.y);
            }
            else if (o is Vector4)
            {
                var v = (Vector4)o;
                return string.Format("new Vector4({0}f, {1}f, {2}f)", v.x, v.y, v.z, v.w);
            }
            else if (o is Color)
            {
                var v = (Color)o;
                return string.Format("new Color({0}f, {1}f, {2}f, {3}f)", v.r, v.g, v.b, v.a);
            }
            else if (o is LayerMask)
            {
                return ((LayerMask)o).value.ToString();
            }
            else
            {
                return (o == null ? "null" : o.ToString());
            }
        }

        static Regex splitCaps = new Regex(@"
                (?<=[A-Z])(?=[A-Z][a-z]) |
                 (?<=[^A-Z])(?=[A-Z]) |
                 (?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace);

        public static string SplitOnCaps(this string s)
        {
            return splitCaps.Replace(s, " ");
        }

        public static string[] excludedNames = new string[] {
            "Invoke",
            "IsInvoking",
            "StartCoroutine",
            "StopCoroutine",
            "InvokeRepeating",
            "CancelInvoke",
            "StopAllCoroutines",
            "SendMessage",
            "BroadcastMessage",
            "SendMessageUpwards",
            "useGUILayout",
            "runInEditMode",
            "CompareTag",
            "hideFlags",
            "name",
            "tag"
        };
    }
}

