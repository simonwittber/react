using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes method call AudioSource.PlayClipAtPoint on the class, then returns a NoResult state.
    /// </summary>
    [System.Serializable]
    
    public class Function_AudioSource_PlayClipAtPoint_clip_position : LeafNode
    {
        public UnityEngine.AudioClip clip;
        public UnityEngine.Vector3 position;

        
        protected override NodeState Execute() {
            UnityEngine.AudioSource.PlayClipAtPoint(clip, position);
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "AudioSource.PlayClipAtPoint";
        public static string GetMenuPath() => "AudioSource/Function/PlayClipAtPoint/(clip, position)";
        public static string Signature() => " (clip,position)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioSource);
    }
}
