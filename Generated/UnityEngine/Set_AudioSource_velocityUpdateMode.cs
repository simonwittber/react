using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_AudioSource_velocityUpdateMode : LeafNode
    {
        public UnityEngine.AudioVelocityUpdateMode value;

        protected AudioSource Component { get; set; }

        protected override NodeState Execute() {
            Component.velocityUpdateMode = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<AudioSource>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET AudioSource.velocityUpdateMode";
        public static string GetMenuPath() => "AudioSource/Set/velocityUpdateMode";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(AudioSource);
    }
}
