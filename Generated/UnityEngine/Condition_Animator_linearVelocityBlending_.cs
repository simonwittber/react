using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Animator_linearVelocityBlending_ : LeafNode
    {

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            if(Component.linearVelocityBlending) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Animator.linearVelocityBlending";
        public static string GetMenuPath() => "Animator/Condition/linearVelocityBlending";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);
    }

    
    [System.Serializable]
    public class Not_Condition_Animator_linearVelocityBlending_ : LeafNode
    {

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.linearVelocityBlending) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Animator.linearVelocityBlending";
        public static string GetMenuPath() => "Animator/Condition/linearVelocityBlending";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);
    }
}
