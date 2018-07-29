using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets HingeJoint2D.connectedAnchor on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_HingeJoint2D_connectedAnchor : LeafNode
    {
        public UnityEngine.Vector2 value;

        protected HingeJoint2D Component { get; set; }

        protected override NodeState Execute() {
            Component.connectedAnchor = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<HingeJoint2D>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET HingeJoint2D.connectedAnchor";
        public static string GetMenuPath() => "HingeJoint2D/Set/connectedAnchor";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(HingeJoint2D);
    }
}
