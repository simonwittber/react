using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets HingeJoint.axis on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_HingeJoint_axis : LeafNode
    {
        public UnityEngine.Vector3 value;

        protected HingeJoint Component { get; set; }

        protected override NodeState Execute() {
            Component.axis = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<HingeJoint>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET HingeJoint.axis";
        public static string GetMenuPath() => "HingeJoint/Set/axis";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(HingeJoint);
    }
}
