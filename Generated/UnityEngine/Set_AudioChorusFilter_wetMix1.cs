using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Sets AudioChorusFilter.wetMix1 on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_AudioChorusFilter_wetMix1 : LeafNode
    {
        public float value;

        protected AudioChorusFilter Component { get; set; }

        protected override NodeState Execute() {
            Component.wetMix1 = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<AudioChorusFilter>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET AudioChorusFilter.wetMix1";
        public static string GetMenuPath() => "AudioChorusFilter/Set/wetMix1";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(AudioChorusFilter);
    }
}
