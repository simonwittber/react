using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Animator_CrossFadeInFixedTime_stateHashName_fixedTransitionDuration_layer_fixedTimeOffset : LeafNode
    {
        public int stateHashName;
        public float fixedTransitionDuration;
        public int layer;
        public float fixedTimeOffset;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.CrossFadeInFixedTime(stateHashName, fixedTransitionDuration, layer, fixedTimeOffset);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Animator.CrossFadeInFixedTime";
        public static string GetMenuPath() => "Animator/Function/CrossFadeInFixedTime/(stateHashName, fixedTransitionDuration, layer, fixedTimeOffset)";
        public static string Signature() => " (stateHashName,fixedTransitionDuration,layer,fixedTimeOffset)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animator), typeof(Function_Animator_CrossFadeInFixedTime_stateHashName_fixedTransitionDuration_layer_fixedTimeOffset));
    }
}
