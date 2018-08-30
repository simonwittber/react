using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Rigidbody2D_freezeRotation_ : LeafNode
    {

        protected UnityEngine.Rigidbody2D Component { get; set; }

        protected override NodeState Execute() {
            if(Component.freezeRotation) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Rigidbody2D>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Rigidbody2D.freezeRotation";
        public static string GetMenuPath() => "Rigidbody2D/Condition/freezeRotation";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody2D);
    }

    
    [System.Serializable]
    public class Not_Condition_Rigidbody2D_freezeRotation_ : LeafNode
    {

        protected UnityEngine.Rigidbody2D Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.freezeRotation) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Rigidbody2D>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Rigidbody2D.freezeRotation";
        public static string GetMenuPath() => "Rigidbody2D/Condition/freezeRotation";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody2D);
    }
}
