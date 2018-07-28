using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of AudioSource.SetSpatializerFloat on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_AudioSource_SetSpatializerFloat_index_value : LeafNode
    {
        public int index;
        public float value;


        protected UnityEngine.AudioSource Component { get; set; }

        protected override NodeState Execute() {
            if(Component.SetSpatializerFloat(index, value)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<UnityEngine.AudioSource>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK AudioSource.SetSpatializerFloat";
        public static string GetMenuPath() => "AudioSource/Condition/SetSpatializerFloat";
        public static string Signature() => " (index,value)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioSource);
    }
}
