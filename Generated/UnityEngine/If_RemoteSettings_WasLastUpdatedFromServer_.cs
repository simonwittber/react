using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
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

    
    [System.Serializable]
    public class NotIf_RemoteSettings_WasLastUpdatedFromServer_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(!UnityEngine.RemoteSettings.WasLastUpdatedFromServer()) {
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
