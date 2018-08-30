using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_RemoteSettings_GetBool_key : LeafNode
    {
        public string key;

        
        protected override NodeState Execute() {
            if(UnityEngine.RemoteSettings.GetBool(key))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK RemoteSettings.GetBool";
        public static string GetMenuPath() => "RemoteSettings/Condition/GetBool/(key)";
        public static string Signature() => " (key)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.RemoteSettings);
    }

    
    [System.Serializable]
    public class Not_Condition_RemoteSettings_GetBool_key : LeafNode
    {
        public string key;

        
        protected override NodeState Execute() {
            if(UnityEngine.RemoteSettings.GetBool(key))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT RemoteSettings.GetBool";
        public static string GetMenuPath() => "RemoteSettings/Condition/GetBool/(key)";
        public static string Signature() => " (key)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.RemoteSettings);
    }
}
