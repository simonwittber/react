using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_AudioEchoFilter_enabled_ : DecoratorNode
    {

        protected UnityEngine.AudioEchoFilter Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.enabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioEchoFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF AudioEchoFilter.enabled";
        public static string GetMenuPath() => "AudioEchoFilter/If/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioEchoFilter);
    }

    
    [System.Serializable]
    public class Not_If_AudioEchoFilter_enabled_ : DecoratorNode
    {

        protected UnityEngine.AudioEchoFilter Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.enabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioEchoFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT AudioEchoFilter.enabled";
        public static string GetMenuPath() => "AudioEchoFilter/If/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioEchoFilter);
    }
}
