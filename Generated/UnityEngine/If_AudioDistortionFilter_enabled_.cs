using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of AudioDistortionFilter.enabled on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_AudioDistortionFilter_enabled_ : DecoratorNode
    {


        protected UnityEngine.AudioDistortionFilter Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.enabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.AudioDistortionFilter>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF AudioDistortionFilter.enabled";
        public static string GetMenuPath() => "AudioDistortionFilter/If/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioDistortionFilter);

    }
}
