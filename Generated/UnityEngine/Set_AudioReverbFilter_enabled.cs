using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets AudioReverbFilter.enabled on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_AudioReverbFilter_enabled : LeafNode
    {
        public bool value;

        protected AudioReverbFilter Component { get; set; }

        protected override NodeState Execute() {
            Component.enabled = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<AudioReverbFilter>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET AudioReverbFilter.enabled";
        public static string GetMenuPath() => "AudioReverbFilter/Set/enabled";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(AudioReverbFilter);
    }
}