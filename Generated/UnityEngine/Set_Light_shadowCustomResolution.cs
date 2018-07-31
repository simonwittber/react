using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Sets Light.shadowCustomResolution on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Light_shadowCustomResolution : LeafNode
    {
        public int value;

        protected Light Component { get; set; }

        protected override NodeState Execute() {
            Component.shadowCustomResolution = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Light>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Light.shadowCustomResolution";
        public static string GetMenuPath() => "Light/Set/shadowCustomResolution";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Light);
    }
}
