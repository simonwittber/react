using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call Animator.CrossFadeInFixedTime on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Animator_CrossFadeInFixedTime_stateName_fixedTransitionDuration_layer_fixedTimeOffset : LeafNode
    {
        public string stateName;
        public float fixedTransitionDuration;
        public int layer;
        public float fixedTimeOffset;


        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.CrossFadeInFixedTime(stateName, fixedTransitionDuration, layer, fixedTimeOffset);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Animator>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Animator.CrossFadeInFixedTime";
        public static string GetMenuPath() => "Animator/Function/CrossFadeInFixedTime/(stateName, fixedTransitionDuration, layer, fixedTimeOffset)";
        public static string Signature() => " (stateName,fixedTransitionDuration,layer,fixedTimeOffset)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animator), typeof(Function_Animator_CrossFadeInFixedTime_stateName_fixedTransitionDuration_layer_fixedTimeOffset));

    }
}
