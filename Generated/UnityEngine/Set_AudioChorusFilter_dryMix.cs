using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_AudioChorusFilter_dryMix : LeafNode
    {
        public float value;

        protected AudioChorusFilter Component { get; set; }

        protected override NodeState Execute() {
            Component.dryMix = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<AudioChorusFilter>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET AudioChorusFilter.dryMix";
        public static string GetMenuPath() => "AudioChorusFilter/Set/dryMix";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(AudioChorusFilter);
    }
}
