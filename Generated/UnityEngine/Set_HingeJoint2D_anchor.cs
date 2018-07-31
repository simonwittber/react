using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Sets HingeJoint2D.anchor on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_HingeJoint2D_anchor : LeafNode
    {
        public UnityEngine.Vector2 value;

        protected HingeJoint2D Component { get; set; }

        protected override NodeState Execute() {
            Component.anchor = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<HingeJoint2D>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET HingeJoint2D.anchor";
        public static string GetMenuPath() => "HingeJoint2D/Set/anchor";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(HingeJoint2D);
    }
}
