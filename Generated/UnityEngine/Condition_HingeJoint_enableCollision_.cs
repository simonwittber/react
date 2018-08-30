using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_HingeJoint_enableCollision_ : LeafNode
    {

        protected UnityEngine.HingeJoint Component { get; set; }

        protected override NodeState Execute() {
            if(Component.enableCollision) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.HingeJoint>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK HingeJoint.enableCollision";
        public static string GetMenuPath() => "HingeJoint/Condition/enableCollision";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.HingeJoint);
    }

    
    [System.Serializable]
    public class Not_Condition_HingeJoint_enableCollision_ : LeafNode
    {

        protected UnityEngine.HingeJoint Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.enableCollision) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.HingeJoint>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT HingeJoint.enableCollision";
        public static string GetMenuPath() => "HingeJoint/Condition/enableCollision";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.HingeJoint);
    }
}
