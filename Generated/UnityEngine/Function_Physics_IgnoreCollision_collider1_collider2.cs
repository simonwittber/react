using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes method call Physics.IgnoreCollision on the class, then returns a NoResult state.
    /// </summary>
    [System.Serializable]
    
    public class Function_Physics_IgnoreCollision_collider1_collider2 : LeafNode
    {
        public UnityEngine.Collider collider1;
        public UnityEngine.Collider collider2;

        
        protected override NodeState Execute() {
            UnityEngine.Physics.IgnoreCollision(collider1, collider2);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Physics.IgnoreCollision";
        public static string GetMenuPath() => "Physics/Function/IgnoreCollision/(collider1, collider2)";
        public static string Signature() => " (collider1,collider2)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
