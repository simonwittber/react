using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_AudioDistortionFilter_enabled_ : LeafNode
    {

        protected UnityEngine.AudioDistortionFilter Component { get; set; }

        protected override NodeState Execute() {
            if(Component.enabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioDistortionFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK AudioDistortionFilter.enabled";
        public static string GetMenuPath() => "AudioDistortionFilter/Condition/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioDistortionFilter);
    }

    
    [System.Serializable]
    public class Not_Condition_AudioDistortionFilter_enabled_ : LeafNode
    {

        protected UnityEngine.AudioDistortionFilter Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.enabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioDistortionFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT AudioDistortionFilter.enabled";
        public static string GetMenuPath() => "AudioDistortionFilter/Condition/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioDistortionFilter);
    }
}
