using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call Animator.SetIKHintPositionWeight on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Animator_SetIKHintPositionWeight_hint_value : LeafNode
    {
        public UnityEngine.AvatarIKHint hint;
        public float value;


        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.SetIKHintPositionWeight(hint, value);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Animator>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Animator.SetIKHintPositionWeight";
        public static string GetMenuPath() => "Animator/Function/SetIKHintPositionWeight";
        public static string Signature() => " (hint,value)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animator), typeof(Function_Animator_SetIKHintPositionWeight_hint_value));

    }
}
