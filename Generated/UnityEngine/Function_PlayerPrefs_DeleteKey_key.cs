using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call PlayerPrefs.DeleteKey on the class, then returns a NoResult state.
    /// </summary>
    [System.Serializable]
    
    public class Function_PlayerPrefs_DeleteKey_key : LeafNode
    {
        public string key;

        
        protected override NodeState Execute() {
            UnityEngine.PlayerPrefs.DeleteKey(key);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "PlayerPrefs.DeleteKey";
        public static string GetMenuPath() => "PlayerPrefs/Function/DeleteKey";
        public static string Signature() => " (key)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.PlayerPrefs);
    }
}
