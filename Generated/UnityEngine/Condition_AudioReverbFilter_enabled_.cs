using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_AudioReverbFilter_enabled_ : LeafNode
    {

        protected UnityEngine.AudioReverbFilter Component { get; set; }

        protected override NodeState Execute() {
            if(Component.enabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioReverbFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK AudioReverbFilter.enabled";
        public static string GetMenuPath() => "AudioReverbFilter/Condition/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioReverbFilter);
    }

    
    [System.Serializable]
    public class Not_Condition_AudioReverbFilter_enabled_ : LeafNode
    {

        protected UnityEngine.AudioReverbFilter Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.enabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioReverbFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT AudioReverbFilter.enabled";
        public static string GetMenuPath() => "AudioReverbFilter/Condition/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioReverbFilter);
    }
}
