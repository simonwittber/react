using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Sets AudioLowPassFilter.lowpassResonanceQ on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_AudioLowPassFilter_lowpassResonanceQ : LeafNode
    {
        public float value;

        protected AudioLowPassFilter Component { get; set; }

        protected override NodeState Execute() {
            Component.lowpassResonanceQ = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<AudioLowPassFilter>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET AudioLowPassFilter.lowpassResonanceQ";
        public static string GetMenuPath() => "AudioLowPassFilter/Set/lowpassResonanceQ";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(AudioLowPassFilter);
    }
}
