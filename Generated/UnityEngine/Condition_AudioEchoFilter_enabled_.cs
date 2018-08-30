using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_AudioEchoFilter_enabled_ : LeafNode
    {

        protected UnityEngine.AudioEchoFilter Component { get; set; }

        protected override NodeState Execute() {
            if(Component.enabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioEchoFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK AudioEchoFilter.enabled";
        public static string GetMenuPath() => "AudioEchoFilter/Condition/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioEchoFilter);
    }

    
    [System.Serializable]
    public class Not_Condition_AudioEchoFilter_enabled_ : LeafNode
    {

        protected UnityEngine.AudioEchoFilter Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.enabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioEchoFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT AudioEchoFilter.enabled";
        public static string GetMenuPath() => "AudioEchoFilter/Condition/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioEchoFilter);
    }
}
