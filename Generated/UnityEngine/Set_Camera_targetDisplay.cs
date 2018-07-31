using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Sets Camera.targetDisplay on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Camera_targetDisplay : LeafNode
    {
        public int value;

        protected Camera Component { get; set; }

        protected override NodeState Execute() {
            Component.targetDisplay = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Camera>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Camera.targetDisplay";
        public static string GetMenuPath() => "Camera/Set/targetDisplay";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Camera);
    }
}
