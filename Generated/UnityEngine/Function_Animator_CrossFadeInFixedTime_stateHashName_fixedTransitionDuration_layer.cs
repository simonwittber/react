using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call Animator.CrossFadeInFixedTime on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Animator_CrossFadeInFixedTime_stateHashName_fixedTransitionDuration_layer : LeafNode
    {
        public int stateHashName;
        public float fixedTransitionDuration;
        public int layer;


        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.CrossFadeInFixedTime(stateHashName, fixedTransitionDuration, layer);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Animator>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Animator.CrossFadeInFixedTime";
        public static string GetMenuPath() => "Animator/Function/CrossFadeInFixedTime/(stateHashName, fixedTransitionDuration, layer)";
        public static string Signature() => " (stateHashName,fixedTransitionDuration,layer)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animator), typeof(Function_Animator_CrossFadeInFixedTime_stateHashName_fixedTransitionDuration_layer));

    }
}
