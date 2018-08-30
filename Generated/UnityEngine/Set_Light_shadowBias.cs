using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Light_shadowBias : LeafNode
    {
        public float value;

        protected Light Component { get; set; }

        protected override NodeState Execute() {
            Component.shadowBias = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Light>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Light.shadowBias";
        public static string GetMenuPath() => "Light/Set/shadowBias";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Light);
    }
}
