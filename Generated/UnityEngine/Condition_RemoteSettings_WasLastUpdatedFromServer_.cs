using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of RemoteSettings.WasLastUpdatedFromServer on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_RemoteSettings_WasLastUpdatedFromServer_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.RemoteSettings.WasLastUpdatedFromServer())
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK RemoteSettings.WasLastUpdatedFromServer";
        public static string GetMenuPath() => "RemoteSettings/Condition/WasLastUpdatedFromServer";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.RemoteSettings);
    }
}
