using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_AudioEchoFilter_delay : LeafNode
    {
        public float value;

        protected AudioEchoFilter Component { get; set; }

        protected override NodeState Execute() {
            Component.delay = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<AudioEchoFilter>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET AudioEchoFilter.delay";
        public static string GetMenuPath() => "AudioEchoFilter/Set/delay";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(AudioEchoFilter);
    }
}
