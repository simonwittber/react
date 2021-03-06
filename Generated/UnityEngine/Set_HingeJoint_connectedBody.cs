using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_HingeJoint_connectedBody : LeafNode
    {
        public UnityEngine.Rigidbody value;

        protected HingeJoint Component { get; set; }

        protected override NodeState Execute() {
            Component.connectedBody = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<HingeJoint>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET HingeJoint.connectedBody";
        public static string GetMenuPath() => "HingeJoint/Set/connectedBody";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(HingeJoint);
    }
}
