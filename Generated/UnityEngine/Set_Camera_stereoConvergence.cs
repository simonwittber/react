using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Camera_stereoConvergence : LeafNode
    {
        public float value;

        protected Camera Component { get; set; }

        protected override NodeState Execute() {
            Component.stereoConvergence = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Camera>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Camera.stereoConvergence";
        public static string GetMenuPath() => "Camera/Set/stereoConvergence";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Camera);
    }
}
