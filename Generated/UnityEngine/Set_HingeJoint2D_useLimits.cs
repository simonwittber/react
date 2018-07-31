using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Sets HingeJoint2D.useLimits on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_HingeJoint2D_useLimits : LeafNode
    {
        public bool value;

        protected HingeJoint2D Component { get; set; }

        protected override NodeState Execute() {
            Component.useLimits = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<HingeJoint2D>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET HingeJoint2D.useLimits";
        public static string GetMenuPath() => "HingeJoint2D/Set/useLimits";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(HingeJoint2D);
    }
}
