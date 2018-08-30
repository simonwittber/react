using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_HingeJoint2D_connectedBody : LeafNode
    {
        public UnityEngine.Rigidbody2D value;

        protected HingeJoint2D Component { get; set; }

        protected override NodeState Execute() {
            Component.connectedBody = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<HingeJoint2D>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET HingeJoint2D.connectedBody";
        public static string GetMenuPath() => "HingeJoint2D/Set/connectedBody";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(HingeJoint2D);
    }
}
