using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Rigidbody_isKinematic_ : LeafNode
    {

        protected UnityEngine.Rigidbody Component { get; set; }

        protected override NodeState Execute() {
            if(Component.isKinematic) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Rigidbody>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Rigidbody.isKinematic";
        public static string GetMenuPath() => "Rigidbody/Condition/isKinematic";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody);
    }

    
    [System.Serializable]
    public class Not_Condition_Rigidbody_isKinematic_ : LeafNode
    {

        protected UnityEngine.Rigidbody Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.isKinematic) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Rigidbody>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Rigidbody.isKinematic";
        public static string GetMenuPath() => "Rigidbody/Condition/isKinematic";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody);
    }
}
