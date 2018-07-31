using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of AudioSource.SetAmbisonicDecoderFloat on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_AudioSource_SetAmbisonicDecoderFloat_index_value : DecoratorNode
    {
        public int index;
        public float value;

        protected UnityEngine.AudioSource Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.SetAmbisonicDecoderFloat(index, value)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioSource>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF AudioSource.SetAmbisonicDecoderFloat";
        public static string GetMenuPath() => "AudioSource/If/SetAmbisonicDecoderFloat";
        public static string Signature() => " (index,value)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioSource);
    }
}
