using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Rigidbody_freezeRotation_ : LeafNode
    {

        protected UnityEngine.Rigidbody Component { get; set; }

        protected override NodeState Execute() {
            if(Component.freezeRotation) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Rigidbody>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Rigidbody.freezeRotation";
        public static string GetMenuPath() => "Rigidbody/Condition/freezeRotation";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody);
    }

    
    [System.Serializable]
    public class Not_Condition_Rigidbody_freezeRotation_ : LeafNode
    {

        protected UnityEngine.Rigidbody Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.freezeRotation) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Rigidbody>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Rigidbody.freezeRotation";
        public static string GetMenuPath() => "Rigidbody/Condition/freezeRotation";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody);
    }
}
