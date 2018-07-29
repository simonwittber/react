using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets AudioHighPassFilter.enabled on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_AudioHighPassFilter_enabled : LeafNode
    {
        public bool value;

        protected AudioHighPassFilter Component { get; set; }

        protected override NodeState Execute() {
            Component.enabled = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<AudioHighPassFilter>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET AudioHighPassFilter.enabled";
        public static string GetMenuPath() => "AudioHighPassFilter/Set/enabled";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(AudioHighPassFilter);
    }
}
