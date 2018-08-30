using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_AudioReverbFilter_isActiveAndEnabled_ : LeafNode
    {

        protected UnityEngine.AudioReverbFilter Component { get; set; }

        protected override NodeState Execute() {
            if(Component.isActiveAndEnabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioReverbFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK AudioReverbFilter.isActiveAndEnabled";
        public static string GetMenuPath() => "AudioReverbFilter/Condition/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioReverbFilter);
    }

    
    [System.Serializable]
    public class Not_Condition_AudioReverbFilter_isActiveAndEnabled_ : LeafNode
    {

        protected UnityEngine.AudioReverbFilter Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.isActiveAndEnabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioReverbFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT AudioReverbFilter.isActiveAndEnabled";
        public static string GetMenuPath() => "AudioReverbFilter/Condition/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioReverbFilter);
    }
}
