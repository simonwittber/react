using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Physics2D_IsTouchingLayers_collider : LeafNode
    {
        public UnityEngine.Collider2D collider;

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics2D.IsTouchingLayers(collider))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Physics2D.IsTouchingLayers";
        public static string GetMenuPath() => "Physics2D/Condition/IsTouchingLayers/(collider)";
        public static string Signature() => " (collider)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics2D);
    }

    
    [System.Serializable]
    public class Not_Condition_Physics2D_IsTouchingLayers_collider : LeafNode
    {
        public UnityEngine.Collider2D collider;

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics2D.IsTouchingLayers(collider))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Physics2D.IsTouchingLayers";
        public static string GetMenuPath() => "Physics2D/Condition/IsTouchingLayers/(collider)";
        public static string Signature() => " (collider)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics2D);
    }
}
