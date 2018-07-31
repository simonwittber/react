using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of AudioSource.ignoreListenerPause on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_AudioSource_ignoreListenerPause_ : DecoratorNode
    {

        protected UnityEngine.AudioSource Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.ignoreListenerPause) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioSource>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF AudioSource.ignoreListenerPause";
        public static string GetMenuPath() => "AudioSource/If/ignoreListenerPause";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioSource);
    }
}
