using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    [System.Serializable]
    
    public class Function_PlayerPrefs_SetInt_key_value : LeafNode
    {
        public string key;
        public int value;

        
        protected override NodeState Execute() {
            UnityEngine.PlayerPrefs.SetInt(key, value);
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "PlayerPrefs.SetInt";
        public static string GetMenuPath() => "PlayerPrefs/Function/SetInt";
        public static string Signature() => " (key,value)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.PlayerPrefs);
    }
}
