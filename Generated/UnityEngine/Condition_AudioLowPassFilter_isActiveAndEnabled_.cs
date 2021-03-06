using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_AudioLowPassFilter_isActiveAndEnabled_ : LeafNode
    {

        protected UnityEngine.AudioLowPassFilter Component { get; set; }

        protected override NodeState Execute() {
            if(Component.isActiveAndEnabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioLowPassFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK AudioLowPassFilter.isActiveAndEnabled";
        public static string GetMenuPath() => "AudioLowPassFilter/Condition/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioLowPassFilter);
    }

    
    [System.Serializable]
    public class Not_Condition_AudioLowPassFilter_isActiveAndEnabled_ : LeafNode
    {

        protected UnityEngine.AudioLowPassFilter Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.isActiveAndEnabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioLowPassFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT AudioLowPassFilter.isActiveAndEnabled";
        public static string GetMenuPath() => "AudioLowPassFilter/Condition/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioLowPassFilter);
    }
}
