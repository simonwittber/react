using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes method call Animator.CrossFade on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Animator_CrossFade_stateHashName_normalizedTransitionDuration_layer_normalizedTimeOffset : LeafNode
    {
        public int stateHashName;
        public float normalizedTransitionDuration;
        public int layer;
        public float normalizedTimeOffset;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.CrossFade(stateHashName, normalizedTransitionDuration, layer, normalizedTimeOffset);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Animator.CrossFade";
        public static string GetMenuPath() => "Animator/Function/CrossFade/(stateHashName, normalizedTransitionDuration, layer, normalizedTimeOffset)";
        public static string Signature() => " (stateHashName,normalizedTransitionDuration,layer,normalizedTimeOffset)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animator), typeof(Function_Animator_CrossFade_stateHashName_normalizedTransitionDuration_layer_normalizedTimeOffset));
    }
}
