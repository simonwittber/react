using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_AudioSource_pitch : LeafNode
    {
        public float value;

        protected AudioSource Component { get; set; }

        protected override NodeState Execute() {
            Component.pitch = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<AudioSource>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET AudioSource.pitch";
        public static string GetMenuPath() => "AudioSource/Set/pitch";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(AudioSource);
    }
}
