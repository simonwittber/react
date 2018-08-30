using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_RemoteSettings_HasKey_key : LeafNode
    {
        public string key;

        
        protected override NodeState Execute() {
            if(UnityEngine.RemoteSettings.HasKey(key))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK RemoteSettings.HasKey";
        public static string GetMenuPath() => "RemoteSettings/Condition/HasKey";
        public static string Signature() => " (key)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.RemoteSettings);
    }

    
    [System.Serializable]
    public class Not_Condition_RemoteSettings_HasKey_key : LeafNode
    {
        public string key;

        
        protected override NodeState Execute() {
            if(UnityEngine.RemoteSettings.HasKey(key))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT RemoteSettings.HasKey";
        public static string GetMenuPath() => "RemoteSettings/Condition/HasKey";
        public static string Signature() => " (key)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.RemoteSettings);
    }
}
