using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of RemoteSettings.GetBool on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_RemoteSettings_GetBool_key_defaultValue : LeafNode
    {
        public string key;
        public bool defaultValue;

        
        protected override NodeState Execute() {
            if(UnityEngine.RemoteSettings.GetBool(key, defaultValue))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK RemoteSettings.GetBool";
        public static string GetMenuPath() => "RemoteSettings/Condition/GetBool/(key, defaultValue)";
        public static string Signature() => " (key,defaultValue)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.RemoteSettings);
    }
}
