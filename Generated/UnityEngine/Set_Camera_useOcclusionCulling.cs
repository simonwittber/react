using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets Camera.useOcclusionCulling on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Camera_useOcclusionCulling : LeafNode
    {
        public bool value;

        protected Camera Component { get; set; }

        protected override NodeState Execute() {
            Component.useOcclusionCulling = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Camera>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Camera.useOcclusionCulling";
        public static string GetMenuPath() => "Camera/Set/useOcclusionCulling";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Camera);
    }
}
