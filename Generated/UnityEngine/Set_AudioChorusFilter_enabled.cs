using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_AudioChorusFilter_enabled : LeafNode
    {
        public bool value;

        protected AudioChorusFilter Component { get; set; }

        protected override NodeState Execute() {
            Component.enabled = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<AudioChorusFilter>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET AudioChorusFilter.enabled";
        public static string GetMenuPath() => "AudioChorusFilter/Set/enabled";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(AudioChorusFilter);
    }
}
