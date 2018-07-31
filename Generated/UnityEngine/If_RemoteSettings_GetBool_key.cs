using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of RemoteSettings.GetBool on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_RemoteSettings_GetBool_key : DecoratorNode
    {
        public string key;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.RemoteSettings.GetBool(key)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF RemoteSettings.GetBool";
        public static string GetMenuPath() => "RemoteSettings/If/GetBool/(key)";
        public static string Signature() => " (key)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.RemoteSettings);
    }
}
