using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets AudioSource.dopplerLevel on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_AudioSource_dopplerLevel : LeafNode
    {
        public float value;

        protected AudioSource Component { get; set; }

        protected override NodeState Execute() {
            Component.dopplerLevel = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<AudioSource>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET AudioSource.dopplerLevel";
        public static string GetMenuPath() => "AudioSource/Set/dopplerLevel";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(AudioSource);
    }
}
