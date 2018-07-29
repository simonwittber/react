using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of AudioHighPassFilter.isActiveAndEnabled on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_AudioHighPassFilter_isActiveAndEnabled_ : LeafNode
    {


        protected UnityEngine.AudioHighPassFilter Component { get; set; }

        protected override NodeState Execute() {
            if(Component.isActiveAndEnabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<UnityEngine.AudioHighPassFilter>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK AudioHighPassFilter.isActiveAndEnabled";
        public static string GetMenuPath() => "AudioHighPassFilter/Condition/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioHighPassFilter);
    }
}