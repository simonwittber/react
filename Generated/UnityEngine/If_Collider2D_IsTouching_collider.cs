using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Collider2D_IsTouching_collider : DecoratorNode
    {
        public UnityEngine.Collider2D collider;

        protected UnityEngine.Collider2D Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.IsTouching(collider)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Collider2D>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Collider2D.IsTouching";
        public static string GetMenuPath() => "Collider2D/If/IsTouching/(collider)";
        public static string Signature() => " (collider)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Collider2D);
    }

    
    [System.Serializable]
    public class Not_If_Collider2D_IsTouching_collider : DecoratorNode
    {
        public UnityEngine.Collider2D collider;

        protected UnityEngine.Collider2D Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.IsTouching(collider)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Collider2D>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT Collider2D.IsTouching";
        public static string GetMenuPath() => "Collider2D/If/IsTouching/(collider)";
        public static string Signature() => " (collider)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Collider2D);
    }
}
