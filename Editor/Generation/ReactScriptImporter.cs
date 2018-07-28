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
            // DifferentMethods.React.ReactTypeRegister.CollectTypes();
            // AssetDatabase.StartAssetEditing();
            foreach (var candidate in ReactCandidateClass.AllCandidates)
            {
                ReactGenerator.GetClass(candidate);
            }
            // AssetDatabase.StopAssetEditing();
            AssetDatabase.Refresh();
        }
    }
}