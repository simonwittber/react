using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_HingeJoint_enablePreprocessing : LeafNode
    {
        public bool value;

        protected HingeJoint Component { get; set; }

        protected override NodeState Execute() {
            Component.enablePreprocessing = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<HingeJoint>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET HingeJoint.enablePreprocessing";
        public static string GetMenuPath() => "HingeJoint/Set/enablePreprocessing";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(HingeJoint);
    }
}
