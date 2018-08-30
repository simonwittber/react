using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_AudioSource_ignoreListenerVolume : LeafNode
    {
        public bool value;

        protected AudioSource Component { get; set; }

        protected override NodeState Execute() {
            Component.ignoreListenerVolume = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<AudioSource>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET AudioSource.ignoreListenerVolume";
        public static string GetMenuPath() => "AudioSource/Set/ignoreListenerVolume";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(AudioSource);
    }
}
