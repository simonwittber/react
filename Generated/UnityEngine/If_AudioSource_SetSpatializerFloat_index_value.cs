using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of AudioSource.SetSpatializerFloat on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_AudioSource_SetSpatializerFloat_index_value : DecoratorNode
    {
        public int index;
        public float value;


        protected UnityEngine.AudioSource Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.SetSpatializerFloat(index, value)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.AudioSource>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF AudioSource.SetSpatializerFloat";
        public static string GetMenuPath() => "AudioSource/If/SetSpatializerFloat";
        public static string Signature() => " (index,value)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioSource);

    }
}
