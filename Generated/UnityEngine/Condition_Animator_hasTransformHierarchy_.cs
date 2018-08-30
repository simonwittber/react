using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Animator_hasTransformHierarchy_ : LeafNode
    {

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            if(Component.hasTransformHierarchy) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Animator.hasTransformHierarchy";
        public static string GetMenuPath() => "Animator/Condition/hasTransformHierarchy";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);
    }

    
    [System.Serializable]
    public class Not_Condition_Animator_hasTransformHierarchy_ : LeafNode
    {

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.hasTransformHierarchy) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Animator.hasTransformHierarchy";
        public static string GetMenuPath() => "Animator/Condition/hasTransformHierarchy";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);
    }
}
