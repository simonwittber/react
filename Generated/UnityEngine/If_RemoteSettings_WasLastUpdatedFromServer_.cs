using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of RemoteSettings.WasLastUpdatedFromServer on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_RemoteSettings_WasLastUpdatedFromServer_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.RemoteSettings.WasLastUpdatedFromServer()) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF RemoteSettings.WasLastUpdatedFromServer";
        public static string GetMenuPath() => "RemoteSettings/If/WasLastUpdatedFromServer";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.RemoteSettings);
    }
}
