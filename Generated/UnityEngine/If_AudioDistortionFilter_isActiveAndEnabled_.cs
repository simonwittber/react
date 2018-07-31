using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of AudioDistortionFilter.isActiveAndEnabled on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_AudioDistortionFilter_isActiveAndEnabled_ : DecoratorNode
    {

        protected UnityEngine.AudioDistortionFilter Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.isActiveAndEnabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioDistortionFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF AudioDistortionFilter.isActiveAndEnabled";
        public static string GetMenuPath() => "AudioDistortionFilter/If/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioDistortionFilter);
    }
}
