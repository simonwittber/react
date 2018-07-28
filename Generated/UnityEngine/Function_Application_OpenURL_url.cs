using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call Application.OpenURL on the class, then returns a NoResult state.
    /// </summary>
    [System.Serializable]
    
    public class Function_Application_OpenURL_url : LeafNode
    {
        public string url;

        
        protected override NodeState Execute() {
            UnityEngine.Application.OpenURL(url);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Application.OpenURL";
        public static string GetMenuPath() => "Application/Function/OpenURL";
        public static string Signature() => " (url)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }
}
