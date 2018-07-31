using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Physics.autoSyncTransforms on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Physics_autoSyncTransforms_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics.autoSyncTransforms)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Physics.autoSyncTransforms";
        public static string GetMenuPath() => "Physics/Condition/autoSyncTransforms";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
