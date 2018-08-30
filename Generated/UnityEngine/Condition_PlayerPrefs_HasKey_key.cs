using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_PlayerPrefs_HasKey_key : LeafNode
    {
        public string key;

        
        protected override NodeState Execute() {
            if(UnityEngine.PlayerPrefs.HasKey(key))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK PlayerPrefs.HasKey";
        public static string GetMenuPath() => "PlayerPrefs/Condition/HasKey";
        public static string Signature() => " (key)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.PlayerPrefs);
    }

    
    [System.Serializable]
    public class Not_Condition_PlayerPrefs_HasKey_key : LeafNode
    {
        public string key;

        
        protected override NodeState Execute() {
            if(UnityEngine.PlayerPrefs.HasKey(key))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT PlayerPrefs.HasKey";
        public static string GetMenuPath() => "PlayerPrefs/Condition/HasKey";
        public static string Signature() => " (key)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.PlayerPrefs);
    }
}
