using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of AudioEchoFilter.enabled on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_AudioEchoFilter_enabled_ : LeafNode
    {


        protected UnityEngine.AudioEchoFilter Component { get; set; }

        protected override NodeState Execute() {
            if(Component.enabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<UnityEngine.AudioEchoFilter>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK AudioEchoFilter.enabled";
        public static string GetMenuPath() => "AudioEchoFilter/Condition/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioEchoFilter);
    }
}
