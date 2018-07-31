using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes method call Physics2D.IgnoreCollision on the class, then returns a NoResult state.
    /// </summary>
    [System.Serializable]
    
    public class Function_Physics2D_IgnoreCollision_collider1_collider2 : LeafNode
    {
        public UnityEngine.Collider2D collider1;
        public UnityEngine.Collider2D collider2;

        
        protected override NodeState Execute() {
            UnityEngine.Physics2D.IgnoreCollision(collider1, collider2);
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Physics2D.IgnoreCollision";
        public static string GetMenuPath() => "Physics2D/Function/IgnoreCollision/(collider1, collider2)";
        public static string Signature() => " (collider1,collider2)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics2D);
    }
}
