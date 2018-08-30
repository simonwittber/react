using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    [System.Serializable]
    
    public class Function_Physics_SyncTransforms_ : LeafNode
    {

        
        protected override NodeState Execute() {
            UnityEngine.Physics.SyncTransforms();
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Physics.SyncTransforms";
        public static string GetMenuPath() => "Physics/Function/SyncTransforms";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
