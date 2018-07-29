using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets AudioHighPassFilter.highpassResonanceQ on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_AudioHighPassFilter_highpassResonanceQ : LeafNode
    {
        public float value;

        protected AudioHighPassFilter Component { get; set; }

        protected override NodeState Execute() {
            Component.highpassResonanceQ = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<AudioHighPassFilter>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET AudioHighPassFilter.highpassResonanceQ";
        public static string GetMenuPath() => "AudioHighPassFilter/Set/highpassResonanceQ";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(AudioHighPassFilter);
    }
}
