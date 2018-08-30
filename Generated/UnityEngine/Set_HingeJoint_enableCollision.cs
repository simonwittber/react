using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_HingeJoint_enableCollision : LeafNode
    {
        public bool value;

        protected HingeJoint Component { get; set; }

        protected override NodeState Execute() {
            Component.enableCollision = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<HingeJoint>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET HingeJoint.enableCollision";
        public static string GetMenuPath() => "HingeJoint/Set/enableCollision";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(HingeJoint);
    }
}
