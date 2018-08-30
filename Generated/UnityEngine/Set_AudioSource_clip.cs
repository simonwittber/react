using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_AudioSource_clip : LeafNode
    {
        public UnityEngine.AudioClip value;

        protected AudioSource Component { get; set; }

        protected override NodeState Execute() {
            Component.clip = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<AudioSource>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET AudioSource.clip";
        public static string GetMenuPath() => "AudioSource/Set/clip";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(AudioSource);
    }
}
