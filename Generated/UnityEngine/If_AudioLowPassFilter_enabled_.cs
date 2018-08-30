using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_AudioLowPassFilter_enabled_ : DecoratorNode
    {

        protected UnityEngine.AudioLowPassFilter Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.enabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioLowPassFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF AudioLowPassFilter.enabled";
        public static string GetMenuPath() => "AudioLowPassFilter/If/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioLowPassFilter);
    }

    
    [System.Serializable]
    public class Not_If_AudioLowPassFilter_enabled_ : DecoratorNode
    {

        protected UnityEngine.AudioLowPassFilter Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.enabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioLowPassFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT AudioLowPassFilter.enabled";
        public static string GetMenuPath() => "AudioLowPassFilter/If/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioLowPassFilter);
    }
}
