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

    public static class ReactGenerator
    {

        static string outputPath;


        public static string GetClass(ReactCandidateClass rcc)
        {
            outputPath = System.IO.Path.GetDirectoryName(AssetDatabase.GUIDToAssetPath(AssetDatabase.FindAssets("t:TextAsset React_CLASSES")[0]));
            if (rcc.propertyType != null)
                return CreatePropertyClass(rcc.className, rcc.type, rcc.propertyType, rcc.isStatic, rcc.name, rcc.prefix, rcc.template);
            else
                return CreateClass(rcc.className, rcc.type, rcc.name, rcc.parameters, rcc.isStatic, rcc.prefix, rcc.template);
        }

        static string CreatePropertyClass(string className, Type componentType, Type propertyType, bool isStatic, string propertyName, string prefix, string template)
        {
            if (componentType == null) return "";
            var usings = new HashSet<string>();
            var code = "";
            if (isStatic)
                code = string.Format("{0}.{1}", componentType.Name, propertyName);
            else
                code = string.Format("Context.gameObject.GetComponent<{0}>().{1}", componentType.FullName, propertyName);
            usings.Add(componentType.Namespace);
            usings.Add(propertyType.Namespace);
            var subPath = System.IO.Path.Combine(outputPath, componentType.Namespace ?? "");
            System.IO.Directory.CreateDirectory(subPath);
            var filePath = System.IO.Path.Combine(subPath, className + ".cs");
            var onEnableCode = "";
            var menuRoot = "";
            var menuPath = menuRoot + componentType.Name + "/" + prefix + "/" + propertyName;
            var niceName = componentType.Name + "." + propertyName;
            var fields = "";
            var helpText = "";
            var attributes = "";

            fields += string.Format("        public {0} {1};\n", ReactTypeRegister.ShortTypeName(propertyType), "value");


            var usingDecs = "";
            foreach (var u in usings)
            {
                if (u != null && u != string.Empty && u != "UnityEngine" && u != "React")
                    usingDecs += "using " + u + ";\n";
            }
            var classCode = template
                .Replace("[USING]", usingDecs)
                .Replace("[ATTRIBUTES]", attributes)
                .Replace("[CLASSNAME]", className)
                .Replace("[CODE]", code)
                .Replace("[PROPERTYNAME]", propertyName)
                .Replace("[COMPONENTTYPE]", componentType.Name)
                .Replace("[PROPERTY_TYPE]", fields)
                .Replace("[MENUPATH]", menuPath)
                .Replace("[NICENAME]", niceName)
                .Replace("[ONENABLE_CODE]", onEnableCode)
                .Replace("[HELPTEXT]", helpText)
                .Replace("[COLOR]", CreateColor(className));
            classCode.Replace("\n\n", "\n");
            System.IO.File.WriteAllText(filePath, classCode);
            return className;
        }

        static string CreateColor(string className)
        {
            UnityEngine.Random.InitState(className.GetHashCode());
            var color = UnityEngine.Random.ColorHSV(0f, 1f, 0.5f, 0.6f, 1f, 1f);
            return string.Format("new Color({0}f,{1}f,{2}f,1f)", color.r, color.g, color.b);
        }

        static string Sanitise(string varName)
        {
            if (varName == "name") return "id";
            return varName;
        }

        static string CreateClass(string className, Type type, string methodName, ParameterInfo[] parameters, bool isStatic, string prefix, string template)
        {
            if (type == null) return "";
            var usings = new HashSet<string>();
            var componentName = type.Name.ToLower();
            var componentType = type.FullName.Replace("+", ".");
            usings.Add(type.Namespace);

            var fields = "";
            var argList = new List<string>();
            var args = "";
            var helpText = "";
            var attributes = "";
            if (parameters != null)
            {
                foreach (var p in parameters)
                {
                    var varName = Sanitise(p.Name);
                    fields += string.Format("        public {0} {1};\n", ReactTypeRegister.ShortTypeName(p.ParameterType), varName);
                    argList.Add(varName);
                    usings.Add(p.ParameterType.Namespace);
                }
                args = string.Join(", ", argList.ToArray());
            }

            var code = "";

            if (isStatic)
            {
                componentName = componentType;
            }
            else
            {
                componentName = string.Format("Context.gameObject.GetComponent<{0}>()", componentType);
            }

            if (parameters == null) //This is a property or field.
                code = string.Format("{0}.{1}", componentName, methodName);
            else
                code = string.Format("{0}.{1}({2})", componentName, methodName, args);

            var polymorphic = false;
            try
            {
                type.GetMethod(methodName);
            }
            catch (AmbiguousMatchException)
            {
                polymorphic = true;
            }
            var signature = "";
            if (parameters != null)
            {
                signature = string.Join("_", (from i in parameters
                                              select i.Name).ToArray());
            }
            var subPath = System.IO.Path.Combine(outputPath, type.Namespace ?? "");
            System.IO.Directory.CreateDirectory(subPath);
            var filePath = System.IO.Path.Combine(subPath, className + ".cs");
            var onEnableCode = "";
            var componentDec = "";

            var menuRoot = "";
            var menuName = "";

            if (parameters != null && parameters.Length > 0 && polymorphic)
            {
                menuName = string.Format("/({0})", string.Join(", ", signature.Split('_')));
            }
            var menuPath = menuRoot + type.Name + "/" + prefix + "/" + methodName + menuName;
            var niceName = type.Name + "." + methodName;
            signature = " (" + signature.Replace('_', ',') + ")";
            var usingDecs = "";
            foreach (var u in usings)
            {
                if (u != null && u != string.Empty && u != "UnityEngine" && u != "React")
                    usingDecs += "using " + u + ";\n";
            }

            var classCode = template
                .Replace("[USING]", usingDecs)
                .Replace("[ATTRIBUTES]", attributes)
                .Replace("[CLASSNAME]", className)
                .Replace("[CODE]", code)
                .Replace("[COMPONENTNAME]", componentName)
                .Replace("[COMPONENTTYPE]", componentType)
                .Replace("[FIELDS]", fields)
                .Replace("[MENUPATH]", menuPath)
                .Replace("[NICENAME]", niceName)
                .Replace("[ONENABLE_CODE]", onEnableCode)
                .Replace("[SIGNATURE]", signature)
                .Replace("[COMPONENT_DEC]", componentDec)
                .Replace("[HELPTEXT]", helpText)
                .Replace("[METHODNAME]", methodName)
                .Replace("[ARGS]", args)
                .Replace("[COLOR]", CreateColor(className));
            classCode.Replace("\n\n", "\n");
            System.IO.File.WriteAllText(filePath, classCode);
            return className;
        }


    }
}
