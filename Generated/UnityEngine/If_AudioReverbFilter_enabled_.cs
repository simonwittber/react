using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of AudioReverbFilter.enabled on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_AudioReverbFilter_enabled_ : DecoratorNode
    {

        protected UnityEngine.AudioReverbFilter Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.enabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioReverbFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF AudioReverbFilter.enabled";
        public static string GetMenuPath() => "AudioReverbFilter/If/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioReverbFilter);
    }
}
