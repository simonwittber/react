using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_HingeJoint_connectedAnchor : LeafNode
    {
        public UnityEngine.Vector3 value;

        protected HingeJoint Component { get; set; }

        protected override NodeState Execute() {
            Component.connectedAnchor = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<HingeJoint>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET HingeJoint.connectedAnchor";
        public static string GetMenuPath() => "HingeJoint/Set/connectedAnchor";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(HingeJoint);
    }
}
