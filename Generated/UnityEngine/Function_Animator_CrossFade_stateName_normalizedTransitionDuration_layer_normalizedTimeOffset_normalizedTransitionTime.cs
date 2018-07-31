using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes method call Animator.CrossFade on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Animator_CrossFade_stateName_normalizedTransitionDuration_layer_normalizedTimeOffset_normalizedTransitionTime : LeafNode
    {
        public string stateName;
        public float normalizedTransitionDuration;
        public int layer;
        public float normalizedTimeOffset;
        public float normalizedTransitionTime;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.CrossFade(stateName, normalizedTransitionDuration, layer, normalizedTimeOffset, normalizedTransitionTime);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Animator.CrossFade";
        public static string GetMenuPath() => "Animator/Function/CrossFade/(stateName, normalizedTransitionDuration, layer, normalizedTimeOffset, normalizedTransitionTime)";
        public static string Signature() => " (stateName,normalizedTransitionDuration,layer,normalizedTimeOffset,normalizedTransitionTime)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animator), typeof(Function_Animator_CrossFade_stateName_normalizedTransitionDuration_layer_normalizedTimeOffset_normalizedTransitionTime));
    }
}
