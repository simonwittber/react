using DifferentMethods.React;
using UnityEngine;
using UnityEngine.Audio;


namespace React.Generated {
    /// <summary>
    /// Sets AudioSource.outputAudioMixerGroup on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_AudioSource_outputAudioMixerGroup : LeafNode
    {
        public UnityEngine.Audio.AudioMixerGroup value;

        protected AudioSource Component { get; set; }

        protected override NodeState Execute() {
            Component.outputAudioMixerGroup = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<AudioSource>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET AudioSource.outputAudioMixerGroup";
        public static string GetMenuPath() => "AudioSource/Set/outputAudioMixerGroup";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(AudioSource);
    }
}
