using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of AudioChorusFilter.isActiveAndEnabled on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_AudioChorusFilter_isActiveAndEnabled_ : DecoratorNode
    {

        protected UnityEngine.AudioChorusFilter Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.isActiveAndEnabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioChorusFilter>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF AudioChorusFilter.isActiveAndEnabled";
        public static string GetMenuPath() => "AudioChorusFilter/If/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioChorusFilter);
    }
}
