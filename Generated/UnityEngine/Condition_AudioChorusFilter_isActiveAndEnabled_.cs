using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_AudioChorusFilter_isActiveAndEnabled_ : LeafNode
    {

        protected UnityEngine.AudioChorusFilter Component { get; set; }

        protected override NodeState Execute() {
            if(Component.isActiveAndEnabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioChorusFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK AudioChorusFilter.isActiveAndEnabled";
        public static string GetMenuPath() => "AudioChorusFilter/Condition/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioChorusFilter);
    }

    
    [System.Serializable]
    public class Not_Condition_AudioChorusFilter_isActiveAndEnabled_ : LeafNode
    {

        protected UnityEngine.AudioChorusFilter Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.isActiveAndEnabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioChorusFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT AudioChorusFilter.isActiveAndEnabled";
        public static string GetMenuPath() => "AudioChorusFilter/Condition/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioChorusFilter);
    }
}
