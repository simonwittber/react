using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets AudioEchoFilter.decayRatio on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_AudioEchoFilter_decayRatio : LeafNode
    {
        public float value;

        protected AudioEchoFilter Component { get; set; }

        protected override NodeState Execute() {
            Component.decayRatio = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<AudioEchoFilter>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET AudioEchoFilter.decayRatio";
        public static string GetMenuPath() => "AudioEchoFilter/Set/decayRatio";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(AudioEchoFilter);
    }
}
