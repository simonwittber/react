using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_TrailRenderer_HasPropertyBlock_ : LeafNode
    {

        protected UnityEngine.TrailRenderer Component { get; set; }

        protected override NodeState Execute() {
            if(Component.HasPropertyBlock()) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.TrailRenderer>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK TrailRenderer.HasPropertyBlock";
        public static string GetMenuPath() => "TrailRenderer/Condition/HasPropertyBlock";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.TrailRenderer);
    }

    
    [System.Serializable]
    public class Not_Condition_TrailRenderer_HasPropertyBlock_ : LeafNode
    {

        protected UnityEngine.TrailRenderer Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.HasPropertyBlock()) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.TrailRenderer>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT TrailRenderer.HasPropertyBlock";
        public static string GetMenuPath() => "TrailRenderer/Condition/HasPropertyBlock";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.TrailRenderer);
    }
}
