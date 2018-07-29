using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets AudioLowPassFilter.cutoffFrequency on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_AudioLowPassFilter_cutoffFrequency : LeafNode
    {
        public float value;

        protected AudioLowPassFilter Component { get; set; }

        protected override NodeState Execute() {
            Component.cutoffFrequency = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<AudioLowPassFilter>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET AudioLowPassFilter.cutoffFrequency";
        public static string GetMenuPath() => "AudioLowPassFilter/Set/cutoffFrequency";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(AudioLowPassFilter);
    }
}
