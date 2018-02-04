using UnityEngine;
using UnityEditor;
using System.Collections;
using UnityEditor.Callbacks;

namespace DifferentMethods.React.Generation
{
    public class ReactScriptImporter
    {
        [MenuItem("Assets/React/Generate Node Classes")]
        static void Generate()
        {
            AssetDatabase.Refresh();
            DifferentMethods.React.ReactTypeRegister.CollectTypes();
        }
    }
}