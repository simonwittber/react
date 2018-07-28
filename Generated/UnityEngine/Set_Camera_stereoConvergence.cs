using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets Camera.stereoConvergence on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Camera_stereoConvergence : LeafNode
    {
        public float value;

        protected Camera Component { get; set; }

        protected override NodeState Execute() {
            Component.stereoConvergence = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Camera>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Camera.stereoConvergence";
        public static string GetMenuPath() => "Camera/Set/stereoConvergence";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Camera);
    }
}
