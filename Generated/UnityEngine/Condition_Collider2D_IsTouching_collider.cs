using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Collider2D_IsTouching_collider : LeafNode
    {
        public UnityEngine.Collider2D collider;

        protected UnityEngine.Collider2D Component { get; set; }

        protected override NodeState Execute() {
            if(Component.IsTouching(collider)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Collider2D>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Collider2D.IsTouching";
        public static string GetMenuPath() => "Collider2D/Condition/IsTouching/(collider)";
        public static string Signature() => " (collider)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Collider2D);
    }

    
    [System.Serializable]
    public class Not_Condition_Collider2D_IsTouching_collider : LeafNode
    {
        public UnityEngine.Collider2D collider;

        protected UnityEngine.Collider2D Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.IsTouching(collider)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Collider2D>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Collider2D.IsTouching";
        public static string GetMenuPath() => "Collider2D/Condition/IsTouching/(collider)";
        public static string Signature() => " (collider)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Collider2D);
    }
}
