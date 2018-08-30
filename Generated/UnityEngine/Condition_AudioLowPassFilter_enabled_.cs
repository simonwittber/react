using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_AudioLowPassFilter_enabled_ : LeafNode
    {

        protected UnityEngine.AudioLowPassFilter Component { get; set; }

        protected override NodeState Execute() {
            if(Component.enabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioLowPassFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK AudioLowPassFilter.enabled";
        public static string GetMenuPath() => "AudioLowPassFilter/Condition/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioLowPassFilter);
    }

    
    [System.Serializable]
    public class Not_Condition_AudioLowPassFilter_enabled_ : LeafNode
    {

        protected UnityEngine.AudioLowPassFilter Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.enabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioLowPassFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT AudioLowPassFilter.enabled";
        public static string GetMenuPath() => "AudioLowPassFilter/Condition/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioLowPassFilter);
    }
}
