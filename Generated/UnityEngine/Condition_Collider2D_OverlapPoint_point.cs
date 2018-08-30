using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Collider2D_OverlapPoint_point : LeafNode
    {
        public UnityEngine.Vector2 point;

        protected UnityEngine.Collider2D Component { get; set; }

        protected override NodeState Execute() {
            if(Component.OverlapPoint(point)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Collider2D>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Collider2D.OverlapPoint";
        public static string GetMenuPath() => "Collider2D/Condition/OverlapPoint";
        public static string Signature() => " (point)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Collider2D);
    }

    
    [System.Serializable]
    public class Not_Condition_Collider2D_OverlapPoint_point : LeafNode
    {
        public UnityEngine.Vector2 point;

        protected UnityEngine.Collider2D Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.OverlapPoint(point)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Collider2D>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Collider2D.OverlapPoint";
        public static string GetMenuPath() => "Collider2D/Condition/OverlapPoint";
        public static string Signature() => " (point)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Collider2D);
    }
}
