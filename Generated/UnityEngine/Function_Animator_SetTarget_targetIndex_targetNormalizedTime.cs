using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call Animator.SetTarget on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Animator_SetTarget_targetIndex_targetNormalizedTime : LeafNode
    {
        public UnityEngine.AvatarTarget targetIndex;
        public float targetNormalizedTime;


        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.SetTarget(targetIndex, targetNormalizedTime);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Animator>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Animator.SetTarget";
        public static string GetMenuPath() => "Animator/Function/SetTarget";
        public static string Signature() => " (targetIndex,targetNormalizedTime)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animator), typeof(Function_Animator_SetTarget_targetIndex_targetNormalizedTime));

    }
}
