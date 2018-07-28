using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of RemoteSettings.GetBool on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_RemoteSettings_GetBool_key_defaultValue : DecoratorNode
    {
        public string key;
        public bool defaultValue;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.RemoteSettings.GetBool(key, defaultValue)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF RemoteSettings.GetBool";
        public static string GetMenuPath() => "RemoteSettings/If/GetBool/(key, defaultValue)";
        public static string Signature() => " (key,defaultValue)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.RemoteSettings);
    }
}
