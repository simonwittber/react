using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Animator_InterruptMatchTarget_completeMatch : LeafNode
    {
        public bool completeMatch;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.InterruptMatchTarget(completeMatch);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Animator.InterruptMatchTarget";
        public static string GetMenuPath() => "Animator/Function/InterruptMatchTarget/(completeMatch)";
        public static string Signature() => " (completeMatch)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animator), typeof(Function_Animator_InterruptMatchTarget_completeMatch));
    }
}
