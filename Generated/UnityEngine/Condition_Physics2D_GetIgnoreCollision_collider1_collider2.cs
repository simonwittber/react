using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Physics2D.GetIgnoreCollision on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Physics2D_GetIgnoreCollision_collider1_collider2 : LeafNode
    {
        public UnityEngine.Collider2D collider1;
        public UnityEngine.Collider2D collider2;

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics2D.GetIgnoreCollision(collider1, collider2))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Physics2D.GetIgnoreCollision";
        public static string GetMenuPath() => "Physics2D/Condition/GetIgnoreCollision";
        public static string Signature() => " (collider1,collider2)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics2D);
    }
}
