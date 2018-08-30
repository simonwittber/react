using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_AudioSource_SetAmbisonicDecoderFloat_index_value : LeafNode
    {
        public int index;
        public float value;

        protected UnityEngine.AudioSource Component { get; set; }

        protected override NodeState Execute() {
            if(Component.SetAmbisonicDecoderFloat(index, value)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioSource>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK AudioSource.SetAmbisonicDecoderFloat";
        public static string GetMenuPath() => "AudioSource/Condition/SetAmbisonicDecoderFloat";
        public static string Signature() => " (index,value)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioSource);
    }

    
    [System.Serializable]
    public class Not_Condition_AudioSource_SetAmbisonicDecoderFloat_index_value : LeafNode
    {
        public int index;
        public float value;

        protected UnityEngine.AudioSource Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.SetAmbisonicDecoderFloat(index, value)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioSource>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT AudioSource.SetAmbisonicDecoderFloat";
        public static string GetMenuPath() => "AudioSource/Condition/SetAmbisonicDecoderFloat";
        public static string Signature() => " (index,value)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioSource);
    }
}
