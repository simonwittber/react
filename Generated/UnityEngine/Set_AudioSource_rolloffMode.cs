using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets AudioSource.rolloffMode on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_AudioSource_rolloffMode : LeafNode
    {
        public UnityEngine.AudioRolloffMode value;

        protected AudioSource Component { get; set; }

        protected override NodeState Execute() {
            Component.rolloffMode = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<AudioSource>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET AudioSource.rolloffMode";
        public static string GetMenuPath() => "AudioSource/Set/rolloffMode";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(AudioSource);
    }
}
