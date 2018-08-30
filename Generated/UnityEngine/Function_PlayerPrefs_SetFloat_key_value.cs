using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    [System.Serializable]
    
    public class Function_PlayerPrefs_SetFloat_key_value : LeafNode
    {
        public string key;
        public float value;

        
        protected override NodeState Execute() {
            UnityEngine.PlayerPrefs.SetFloat(key, value);
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "PlayerPrefs.SetFloat";
        public static string GetMenuPath() => "PlayerPrefs/Function/SetFloat";
        public static string Signature() => " (key,value)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.PlayerPrefs);
    }
}
