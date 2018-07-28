using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call AudioSource.PlayDelayed on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_AudioSource_PlayDelayed_delay : LeafNode
    {
        public float delay;


        protected UnityEngine.AudioSource Component { get; set; }

        protected override NodeState Execute() {
            Component.PlayDelayed(delay);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.AudioSource>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "AudioSource.PlayDelayed";
        public static string GetMenuPath() => "AudioSource/Function/PlayDelayed";
        public static string Signature() => " (delay)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioSource);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.AudioSource), typeof(Function_AudioSource_PlayDelayed_delay));

    }
}
