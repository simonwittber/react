using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Camera_cullingMask : LeafNode
    {
        public int value;

        protected Camera Component { get; set; }

        protected override NodeState Execute() {
            Component.cullingMask = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Camera>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Camera.cullingMask";
        public static string GetMenuPath() => "Camera/Set/cullingMask";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Camera);
    }
}
