using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes method call PlayerPrefs.SetString on the class, then returns a NoResult state.
    /// </summary>
    [System.Serializable]
    
    public class Function_PlayerPrefs_SetString_key_value : LeafNode
    {
        public string key;
        public string value;

        
        protected override NodeState Execute() {
            UnityEngine.PlayerPrefs.SetString(key, value);
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "PlayerPrefs.SetString";
        public static string GetMenuPath() => "PlayerPrefs/Function/SetString";
        public static string Signature() => " (key,value)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.PlayerPrefs);
    }
}
