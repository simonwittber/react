using UnityEngine;
using UnityEditor;
using System.Collections;
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using UnityEngine.AI;
using DifferentMethods.React.Editor;

namespace DifferentMethods.React.Generation
{
    [System.Serializable]
    public class ReactCandidateClass
    {

        public Type type;
        public Type propertyType;
        public string name;
        public ParameterInfo[] parameters;
        public bool isStatic;
        public string prefix;
        public string template;
        public string className;

        public string NiceName
        {
            get
            {
                return string.Format("{0} {1}.{2}", prefix, type.Name, name);
            }
        }

        public string Signature
        {
            get
            {
                var s = "";
                if (parameters != null)
                {
                    s = string.Format("({0})", string.Join(",", (from i in parameters select i.Name).ToArray()));
                }
                return s;
            }
        }

        [UnityEditor.Callbacks.DidReloadScripts]
        public static void Clear()
        {
            candidates.Clear();
        }

        public static List<ReactCandidateClass> AllCandidates
        {
            get
            {
                if (candidates == null || candidates.Count == 0)
                    candidates = CollectCandidates();
                return candidates;
            }
        }

        static string ifTemplate, conditionTemplate, functionTemplate, setTemplate;
        static string staticIfTemplate, staticConditionTemplate, staticFunctionTemplate, staticSetTemplate;
        static List<ReactCandidateClass> candidates = new List<ReactCandidateClass>();

        public static ReactCandidateClass Find(string typeName)
        {
            foreach (var i in AllCandidates)
            {
                if (typeName.EndsWith(i.className)) return i;
            }
            return null;
        }


        static void AddCandidateClass(Type type, Type propertyType, string name, ParameterInfo[] parameters, bool isStatic, string prefix, string template)
        {
            var className = "";
            if (propertyType == null)
            {
                className = prefix + "_" + type.Name + "_" + name + "_";
                var signature = "";
                if (parameters != null)
                {
                    signature = string.Join("_", (from i in parameters
                                                  select i.Name).ToArray());
                }
                className += signature;
            }
            else
            {
                className = prefix + "_" + type.Name + "_" + name + "";
            }

            if (ReactTypeRegister.Find(className) == null)
            {
                var candidate = new ReactCandidateClass()
                {
                    type = type,
                    propertyType = propertyType,
                    name = name,
                    parameters = parameters,
                    isStatic = isStatic,
                    prefix = prefix,
                    template = template,
                    className = className
                };
                candidates.Add(candidate);
                List<ReactCandidateClass> clist;
                if (!typeMap.TryGetValue(type, out clist))
                    typeMap[type] = clist = new List<ReactCandidateClass>();
                clist.Add(candidate);
            }
        }

        static Dictionary<System.Type, List<ReactCandidateClass>> typeMap = new Dictionary<Type, List<ReactCandidateClass>>(1024);
        public static IEnumerable<ReactCandidateClass> CandidatesForType(System.Type type)
        {
            if (typeMap.Count == 0)
            {
                CollectCandidates();
            }
            List<ReactCandidateClass> clist;
            if (typeMap.TryGetValue(type, out clist))
                foreach (var cc in clist) yield return cc;
        }

        static List<ReactCandidateClass> CollectAllCandidates()
        {
            ifTemplate = ReactEditorUtility.LoadTemplate("React_If_Template");
            conditionTemplate = ReactEditorUtility.LoadTemplate("React_Condition_Template");
            functionTemplate = ReactEditorUtility.LoadTemplate("React_Function_Template");
            setTemplate = ReactEditorUtility.LoadTemplate("React_Set_Template");
            staticIfTemplate = ReactEditorUtility.LoadTemplate("React_Static_If_Template");
            staticConditionTemplate = ReactEditorUtility.LoadTemplate("React_Static_Condition_Template");
            staticFunctionTemplate = ReactEditorUtility.LoadTemplate("React_Static_Function_Template");
            staticSetTemplate = ReactEditorUtility.LoadTemplate("React_Static_Set_Template");

            CreateClassesForType(typeof(RemoteSettings));
            CreateClassesForType(typeof(Cursor));
            CreateClassesForType(typeof(Debug));
            CreateClassesForType(typeof(Handheld));
            CreateClassesForType(typeof(Input));
            CreateClassesForType(typeof(ParticleSystem));
            CreateClassesForType(typeof(Application));
            CreateClassesForType(typeof(Physics));
            CreateClassesForType(typeof(PlayerPrefs));

            var typeBlacklist = new HashSet<string>(new[] { "NetworkScenePostProcess" });
            var assBlacklist = new[] { "UnityEditor", "HoloLens" };
            foreach (var ass in AppDomain.CurrentDomain.GetAssemblies())
            {
                var skip = false;
                foreach (var ab in assBlacklist)
                    if (ass.IsDynamic || ass.Location.Contains(ab)) skip = true;
                if (skip) continue;
                foreach (var ct in ass.GetTypes())
                {
                    if (!ct.IsSubclassOf(typeof(Component))) continue;
                    if (ct.GetCustomAttributes(typeof(ObsoleteAttribute), true).Length > 0) continue;
                    if (ct.IsValueType) continue;
                    if (!ct.IsPublic) continue;
                    if (typeBlacklist.Contains(ct.Name)) continue;
                    CreateClassesForType(ct);
                }

            }
            return candidates;
        }

        static List<ReactCandidateClass> CollectCandidates()
        {
            ifTemplate = ReactEditorUtility.LoadTemplate("React_If_Template");
            conditionTemplate = ReactEditorUtility.LoadTemplate("React_Condition_Template");
            functionTemplate = ReactEditorUtility.LoadTemplate("React_Function_Template");
            setTemplate = ReactEditorUtility.LoadTemplate("React_Set_Template");
            staticIfTemplate = ReactEditorUtility.LoadTemplate("React_Static_If_Template");
            staticConditionTemplate = ReactEditorUtility.LoadTemplate("React_Static_Condition_Template");
            staticFunctionTemplate = ReactEditorUtility.LoadTemplate("React_Static_Function_Template");
            staticSetTemplate = ReactEditorUtility.LoadTemplate("React_Static_Set_Template");

            CreateClassesForType(typeof(RemoteSettings));
            CreateClassesForType(typeof(Cursor));
            CreateClassesForType(typeof(Debug));
            CreateClassesForType(typeof(Handheld));
            CreateClassesForType(typeof(Input));
            CreateClassesForType(typeof(ParticleSystem));
            CreateClassesForType(typeof(Application));
            CreateClassesForType(typeof(Physics));
            CreateClassesForType(typeof(PlayerPrefs));

            foreach (var i in AssetDatabase.FindAssets("t:ReactComponentDatabase"))
            {
                var db = AssetDatabase.LoadAssetAtPath<ReactComponentDatabase>(AssetDatabase.GUIDToAssetPath(i));
                foreach (var ms in db.scripts)
                {
                    var ct = ms.GetClass();
                    if (!ct.IsSubclassOf(typeof(Component))) continue;
                    if (ct.GetCustomAttributes(typeof(ObsoleteAttribute), true).Length > 0) continue;
                    if (ct.IsValueType) continue;
                    if (!ct.IsPublic) continue;
                    CreateClassesForType(ct);
                }
            }
            return candidates;
        }

        static void CreateClassesForType(System.Type type)
        {

            foreach (var p in type.GetProperties())
            {
                if (ReactTypeRegister.IsSupportedParameter(p.PropertyType))
                {
                    if (p.GetCustomAttributes(typeof(ObsoleteAttribute), true).Length > 0)
                        continue;
                    if (ReactTypeRegister.excludedNames.Contains(p.Name))
                        continue;

                    if (p.PropertyType == typeof(bool))
                    {
                        if (p.CanRead)
                        {
                            var stat = p.GetGetMethod().IsStatic;
                            AddCandidateClass(type, null, p.Name, null, stat, "If", stat ? staticIfTemplate : ifTemplate);
                            AddCandidateClass(type, null, p.Name, null, stat, "Condition", stat ? staticConditionTemplate : conditionTemplate);
                        }
                    }
                    if (p.CanWrite)
                    {
                        var pmi = p.GetSetMethod();
                        if (pmi == null) break;
                        var stat = pmi.IsStatic;
                        AddCandidateClass(type, p.PropertyType, p.Name, null, stat, "Set", stat ? staticSetTemplate : setTemplate);
                    }

                }
            }
            foreach (var mi in type.GetMethods())
            {
                if (!ReactTypeRegister.IsSupportedMethod(mi))
                    continue;

                if (mi.ReturnType == typeof(bool))
                {
                    AddCandidateClass(type, null, mi.Name, mi.GetParameters(), mi.IsStatic, "If", mi.IsStatic ? staticIfTemplate : ifTemplate);
                    AddCandidateClass(type, null, mi.Name, mi.GetParameters(), mi.IsStatic, "Condition", mi.IsStatic ? staticConditionTemplate : conditionTemplate);
                }
                if (mi.ReturnType == typeof(void))
                {
                    AddCandidateClass(type, null, mi.Name, mi.GetParameters(), mi.IsStatic, "Function", mi.IsStatic ? staticFunctionTemplate : functionTemplate);
                }
            }
        }
    }
}