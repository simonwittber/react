using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Debug.isDebugBuild on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Debug_isDebugBuild_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Debug.isDebugBuild)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Debug.isDebugBuild";
        public static string GetMenuPath() => "Debug/Condition/isDebugBuild";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Debug);
    }
}
