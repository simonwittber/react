using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets Camera.orthographicSize on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Camera_orthographicSize : LeafNode
    {
        public float value;

        protected Camera Component { get; set; }

        protected override NodeState Execute() {
            Component.orthographicSize = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Camera>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Camera.orthographicSize";
        public static string GetMenuPath() => "Camera/Set/orthographicSize";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Camera);
    }
}
