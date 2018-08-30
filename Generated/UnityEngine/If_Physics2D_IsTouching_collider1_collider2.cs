using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Physics2D_IsTouching_collider1_collider2 : DecoratorNode
    {
        public UnityEngine.Collider2D collider1;
        public UnityEngine.Collider2D collider2;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Physics2D.IsTouching(collider1, collider2)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics2D.IsTouching";
        public static string GetMenuPath() => "Physics2D/If/IsTouching/(collider1, collider2)";
        public static string Signature() => " (collider1,collider2)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics2D);
    }

    
    [System.Serializable]
    public class NotIf_Physics2D_IsTouching_collider1_collider2 : DecoratorNode
    {
        public UnityEngine.Collider2D collider1;
        public UnityEngine.Collider2D collider2;

        
        protected override NodeState Execute() 
        {
            if(!UnityEngine.Physics2D.IsTouching(collider1, collider2)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics2D.IsTouching";
        public static string GetMenuPath() => "Physics2D/If/IsTouching/(collider1, collider2)";
        public static string Signature() => " (collider1,collider2)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics2D);
    }
}
