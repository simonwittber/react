using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes method call RemoteSettings.ForceUpdate on the class, then returns a NoResult state.
    /// </summary>
    [System.Serializable]
    
    public class Function_RemoteSettings_ForceUpdate_ : LeafNode
    {

        
        protected override NodeState Execute() {
            UnityEngine.RemoteSettings.ForceUpdate();
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "RemoteSettings.ForceUpdate";
        public static string GetMenuPath() => "RemoteSettings/Function/ForceUpdate";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.RemoteSettings);
    }
}
