using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of AudioSource.isPlaying on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_AudioSource_isPlaying_ : DecoratorNode
    {


        protected UnityEngine.AudioSource Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.isPlaying) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.AudioSource>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF AudioSource.isPlaying";
        public static string GetMenuPath() => "AudioSource/If/isPlaying";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioSource);

    }
}
