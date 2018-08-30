using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_TrailRenderer_emitting_ : LeafNode
    {

        protected UnityEngine.TrailRenderer Component { get; set; }

        protected override NodeState Execute() {
            if(Component.emitting) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.TrailRenderer>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK TrailRenderer.emitting";
        public static string GetMenuPath() => "TrailRenderer/Condition/emitting";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.TrailRenderer);
    }

    
    [System.Serializable]
    public class Not_Condition_TrailRenderer_emitting_ : LeafNode
    {

        protected UnityEngine.TrailRenderer Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.emitting) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.TrailRenderer>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT TrailRenderer.emitting";
        public static string GetMenuPath() => "TrailRenderer/Condition/emitting";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.TrailRenderer);
    }
}
