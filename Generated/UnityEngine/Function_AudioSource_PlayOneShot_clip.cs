using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes method call AudioSource.PlayOneShot on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_AudioSource_PlayOneShot_clip : LeafNode
    {
        public UnityEngine.AudioClip clip;


        protected UnityEngine.AudioSource Component { get; set; }

        protected override NodeState Execute() {
            Component.PlayOneShot(clip);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.AudioSource>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "AudioSource.PlayOneShot";
        public static string GetMenuPath() => "AudioSource/Function/PlayOneShot/(clip)";
        public static string Signature() => " (clip)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioSource);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.AudioSource), typeof(Function_AudioSource_PlayOneShot_clip));

    }
}
