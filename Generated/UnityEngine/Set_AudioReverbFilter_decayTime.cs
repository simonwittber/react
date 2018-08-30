using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_AudioReverbFilter_decayTime : LeafNode
    {
        public float value;

        protected AudioReverbFilter Component { get; set; }

        protected override NodeState Execute() {
            Component.decayTime = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<AudioReverbFilter>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET AudioReverbFilter.decayTime";
        public static string GetMenuPath() => "AudioReverbFilter/Set/decayTime";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(AudioReverbFilter);
    }
}
