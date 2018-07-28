using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets Light.bounceIntensity on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Light_bounceIntensity : LeafNode
    {
        public float value;

        protected Light Component { get; set; }

        protected override NodeState Execute() {
            Component.bounceIntensity = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Light>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Light.bounceIntensity";
        public static string GetMenuPath() => "Light/Set/bounceIntensity";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Light);
    }
}
