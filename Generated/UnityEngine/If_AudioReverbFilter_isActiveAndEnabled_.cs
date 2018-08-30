using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_AudioReverbFilter_isActiveAndEnabled_ : DecoratorNode
    {

        protected UnityEngine.AudioReverbFilter Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.isActiveAndEnabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioReverbFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF AudioReverbFilter.isActiveAndEnabled";
        public static string GetMenuPath() => "AudioReverbFilter/If/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioReverbFilter);
    }

    
    [System.Serializable]
    public class Not_If_AudioReverbFilter_isActiveAndEnabled_ : DecoratorNode
    {

        protected UnityEngine.AudioReverbFilter Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.isActiveAndEnabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioReverbFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT AudioReverbFilter.isActiveAndEnabled";
        public static string GetMenuPath() => "AudioReverbFilter/If/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioReverbFilter);
    }
}
