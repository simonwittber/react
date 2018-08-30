using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_HingeJoint_massScale : LeafNode
    {
        public float value;

        protected HingeJoint Component { get; set; }

        protected override NodeState Execute() {
            Component.massScale = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<HingeJoint>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET HingeJoint.massScale";
        public static string GetMenuPath() => "HingeJoint/Set/massScale";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(HingeJoint);
    }
}
