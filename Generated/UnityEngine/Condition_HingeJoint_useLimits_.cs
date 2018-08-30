using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_HingeJoint_useLimits_ : LeafNode
    {

        protected UnityEngine.HingeJoint Component { get; set; }

        protected override NodeState Execute() {
            if(Component.useLimits) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.HingeJoint>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK HingeJoint.useLimits";
        public static string GetMenuPath() => "HingeJoint/Condition/useLimits";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.HingeJoint);
    }

    
    [System.Serializable]
    public class Not_Condition_HingeJoint_useLimits_ : LeafNode
    {

        protected UnityEngine.HingeJoint Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.useLimits) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.HingeJoint>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT HingeJoint.useLimits";
        public static string GetMenuPath() => "HingeJoint/Condition/useLimits";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.HingeJoint);
    }
}
