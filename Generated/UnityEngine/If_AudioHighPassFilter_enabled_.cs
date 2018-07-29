using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of AudioHighPassFilter.enabled on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_AudioHighPassFilter_enabled_ : DecoratorNode
    {


        protected UnityEngine.AudioHighPassFilter Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.enabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.AudioHighPassFilter>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF AudioHighPassFilter.enabled";
        public static string GetMenuPath() => "AudioHighPassFilter/If/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioHighPassFilter);

    }
}
