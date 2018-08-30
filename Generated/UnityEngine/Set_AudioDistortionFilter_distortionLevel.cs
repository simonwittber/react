using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_AudioDistortionFilter_distortionLevel : LeafNode
    {
        public float value;

        protected AudioDistortionFilter Component { get; set; }

        protected override NodeState Execute() {
            Component.distortionLevel = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<AudioDistortionFilter>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET AudioDistortionFilter.distortionLevel";
        public static string GetMenuPath() => "AudioDistortionFilter/Set/distortionLevel";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(AudioDistortionFilter);
    }
}
