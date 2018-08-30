using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_AudioSource_ignoreListenerPause : LeafNode
    {
        public bool value;

        protected AudioSource Component { get; set; }

        protected override NodeState Execute() {
            Component.ignoreListenerPause = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<AudioSource>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET AudioSource.ignoreListenerPause";
        public static string GetMenuPath() => "AudioSource/Set/ignoreListenerPause";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(AudioSource);
    }
}
