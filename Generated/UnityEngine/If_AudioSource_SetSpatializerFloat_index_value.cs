using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
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

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioSource>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF AudioSource.SetSpatializerFloat";
        public static string GetMenuPath() => "AudioSource/If/SetSpatializerFloat";
        public static string Signature() => " (index,value)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioSource);
    }

    
    [System.Serializable]
    public class Not_If_AudioSource_SetSpatializerFloat_index_value : DecoratorNode
    {
        public int index;
        public float value;

        protected UnityEngine.AudioSource Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.SetSpatializerFloat(index, value)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioSource>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT AudioSource.SetSpatializerFloat";
        public static string GetMenuPath() => "AudioSource/If/SetSpatializerFloat";
        public static string Signature() => " (index,value)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioSource);
    }
}
