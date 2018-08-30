using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Physics2D_IsTouchingLayers_collider : DecoratorNode
    {
        public UnityEngine.Collider2D collider;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Physics2D.IsTouchingLayers(collider)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics2D.IsTouchingLayers";
        public static string GetMenuPath() => "Physics2D/If/IsTouchingLayers/(collider)";
        public static string Signature() => " (collider)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics2D);
    }

    
    [System.Serializable]
    public class NotIf_Physics2D_IsTouchingLayers_collider : DecoratorNode
    {
        public UnityEngine.Collider2D collider;

        
        protected override NodeState Execute() 
        {
            if(!UnityEngine.Physics2D.IsTouchingLayers(collider)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics2D.IsTouchingLayers";
        public static string GetMenuPath() => "Physics2D/If/IsTouchingLayers/(collider)";
        public static string Signature() => " (collider)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics2D);
    }
}
