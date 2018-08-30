using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Animator_logWarnings_ : LeafNode
    {

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            if(Component.logWarnings) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Animator.logWarnings";
        public static string GetMenuPath() => "Animator/Condition/logWarnings";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);
    }

    
    [System.Serializable]
    public class Not_Condition_Animator_logWarnings_ : LeafNode
    {

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.logWarnings) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Animator.logWarnings";
        public static string GetMenuPath() => "Animator/Condition/logWarnings";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);
    }
}
