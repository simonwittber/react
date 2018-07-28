using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of AudioSource.bypassListenerEffects on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_AudioSource_bypassListenerEffects_ : LeafNode
    {


        protected UnityEngine.AudioSource Component { get; set; }

        protected override NodeState Execute() {
            if(Component.bypassListenerEffects) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<UnityEngine.AudioSource>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK AudioSource.bypassListenerEffects";
        public static string GetMenuPath() => "AudioSource/Condition/bypassListenerEffects";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioSource);
    }
}
