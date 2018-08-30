using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_AudioLowPassFilter_enabled : LeafNode
    {
        public bool value;

        protected AudioLowPassFilter Component { get; set; }

        protected override NodeState Execute() {
            Component.enabled = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<AudioLowPassFilter>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET AudioLowPassFilter.enabled";
        public static string GetMenuPath() => "AudioLowPassFilter/Set/enabled";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(AudioLowPassFilter);
    }
}
