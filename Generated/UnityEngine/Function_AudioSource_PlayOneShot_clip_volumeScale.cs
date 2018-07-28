using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call AudioSource.PlayOneShot on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_AudioSource_PlayOneShot_clip_volumeScale : LeafNode
    {
        public UnityEngine.AudioClip clip;
        public float volumeScale;


        protected UnityEngine.AudioSource Component { get; set; }

        protected override NodeState Execute() {
            Component.PlayOneShot(clip, volumeScale);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.AudioSource>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "AudioSource.PlayOneShot";
        public static string GetMenuPath() => "AudioSource/Function/PlayOneShot/(clip, volumeScale)";
        public static string Signature() => " (clip,volumeScale)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioSource);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.AudioSource), typeof(Function_AudioSource_PlayOneShot_clip_volumeScale));

    }
}
