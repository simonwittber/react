using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call AudioSource.PlayClipAtPoint on the class, then returns a NoResult state.
    /// </summary>
    [System.Serializable]
    
    public class Function_AudioSource_PlayClipAtPoint_clip_position_volume : LeafNode
    {
        public UnityEngine.AudioClip clip;
        public UnityEngine.Vector3 position;
        public float volume;

        
        protected override NodeState Execute() {
            UnityEngine.AudioSource.PlayClipAtPoint(clip, position, volume);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "AudioSource.PlayClipAtPoint";
        public static string GetMenuPath() => "AudioSource/Function/PlayClipAtPoint/(clip, position, volume)";
        public static string Signature() => " (clip,position,volume)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioSource);
    }
}
