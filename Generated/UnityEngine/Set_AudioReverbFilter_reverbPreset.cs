using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Sets AudioReverbFilter.reverbPreset on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_AudioReverbFilter_reverbPreset : LeafNode
    {
        public UnityEngine.AudioReverbPreset value;

        protected AudioReverbFilter Component { get; set; }

        protected override NodeState Execute() {
            Component.reverbPreset = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<AudioReverbFilter>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET AudioReverbFilter.reverbPreset";
        public static string GetMenuPath() => "AudioReverbFilter/Set/reverbPreset";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(AudioReverbFilter);
    }
}
