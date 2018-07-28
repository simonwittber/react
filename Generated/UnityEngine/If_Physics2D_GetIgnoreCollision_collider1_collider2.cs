using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Physics2D.GetIgnoreCollision on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Physics2D_GetIgnoreCollision_collider1_collider2 : DecoratorNode
    {
        public UnityEngine.Collider2D collider1;
        public UnityEngine.Collider2D collider2;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Physics2D.GetIgnoreCollision(collider1, collider2)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics2D.GetIgnoreCollision";
        public static string GetMenuPath() => "Physics2D/If/GetIgnoreCollision";
        public static string Signature() => " (collider1,collider2)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics2D);
    }
}
