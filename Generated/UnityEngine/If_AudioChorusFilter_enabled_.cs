using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_AudioChorusFilter_enabled_ : DecoratorNode
    {

        protected UnityEngine.AudioChorusFilter Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.enabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioChorusFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF AudioChorusFilter.enabled";
        public static string GetMenuPath() => "AudioChorusFilter/If/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioChorusFilter);
    }

    
    [System.Serializable]
    public class Not_If_AudioChorusFilter_enabled_ : DecoratorNode
    {

        protected UnityEngine.AudioChorusFilter Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.enabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioChorusFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT AudioChorusFilter.enabled";
        public static string GetMenuPath() => "AudioChorusFilter/If/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioChorusFilter);
    }
}
