using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes method call Animator.ResetTrigger on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Animator_ResetTrigger_name : LeafNode
    {
        public string id;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.ResetTrigger(id);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Animator.ResetTrigger";
        public static string GetMenuPath() => "Animator/Function/ResetTrigger/(name)";
        public static string Signature() => " (name)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animator), typeof(Function_Animator_ResetTrigger_name));
    }
}
