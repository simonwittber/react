using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_AudioEchoFilter_isActiveAndEnabled_ : DecoratorNode
    {

        protected UnityEngine.AudioEchoFilter Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.isActiveAndEnabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioEchoFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF AudioEchoFilter.isActiveAndEnabled";
        public static string GetMenuPath() => "AudioEchoFilter/If/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioEchoFilter);
    }

    
    [System.Serializable]
    public class Not_If_AudioEchoFilter_isActiveAndEnabled_ : DecoratorNode
    {

        protected UnityEngine.AudioEchoFilter Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.isActiveAndEnabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioEchoFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT AudioEchoFilter.isActiveAndEnabled";
        public static string GetMenuPath() => "AudioEchoFilter/If/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioEchoFilter);
    }
}
