using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_AudioHighPassFilter_isActiveAndEnabled_ : LeafNode
    {

        protected UnityEngine.AudioHighPassFilter Component { get; set; }

        protected override NodeState Execute() {
            if(Component.isActiveAndEnabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioHighPassFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK AudioHighPassFilter.isActiveAndEnabled";
        public static string GetMenuPath() => "AudioHighPassFilter/Condition/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioHighPassFilter);
    }

    
    [System.Serializable]
    public class Not_Condition_AudioHighPassFilter_isActiveAndEnabled_ : LeafNode
    {

        protected UnityEngine.AudioHighPassFilter Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.isActiveAndEnabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioHighPassFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT AudioHighPassFilter.isActiveAndEnabled";
        public static string GetMenuPath() => "AudioHighPassFilter/Condition/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioHighPassFilter);
    }
}
