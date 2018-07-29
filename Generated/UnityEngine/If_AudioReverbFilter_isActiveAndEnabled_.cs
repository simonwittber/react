using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of AudioReverbFilter.isActiveAndEnabled on the active gameObject is true.
    /// </summary>
    
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

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.AudioReverbFilter>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF AudioReverbFilter.isActiveAndEnabled";
        public static string GetMenuPath() => "AudioReverbFilter/If/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioReverbFilter);

    }
}
