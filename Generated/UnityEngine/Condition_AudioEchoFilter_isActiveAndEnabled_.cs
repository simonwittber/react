using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_AudioEchoFilter_isActiveAndEnabled_ : LeafNode
    {

        protected UnityEngine.AudioEchoFilter Component { get; set; }

        protected override NodeState Execute() {
            if(Component.isActiveAndEnabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioEchoFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK AudioEchoFilter.isActiveAndEnabled";
        public static string GetMenuPath() => "AudioEchoFilter/Condition/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioEchoFilter);
    }

    
    [System.Serializable]
    public class Not_Condition_AudioEchoFilter_isActiveAndEnabled_ : LeafNode
    {

        protected UnityEngine.AudioEchoFilter Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.isActiveAndEnabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioEchoFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT AudioEchoFilter.isActiveAndEnabled";
        public static string GetMenuPath() => "AudioEchoFilter/Condition/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioEchoFilter);
    }
}
