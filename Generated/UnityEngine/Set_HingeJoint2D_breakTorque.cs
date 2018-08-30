using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_HingeJoint2D_breakTorque : LeafNode
    {
        public float value;

        protected HingeJoint2D Component { get; set; }

        protected override NodeState Execute() {
            Component.breakTorque = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<HingeJoint2D>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET HingeJoint2D.breakTorque";
        public static string GetMenuPath() => "HingeJoint2D/Set/breakTorque";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(HingeJoint2D);
    }
}
