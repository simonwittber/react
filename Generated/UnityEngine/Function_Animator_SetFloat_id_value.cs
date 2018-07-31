using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes method call Animator.SetFloat on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Animator_SetFloat_id_value : LeafNode
    {
        public int id;
        public float value;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.SetFloat(id, value);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Animator.SetFloat";
        public static string GetMenuPath() => "Animator/Function/SetFloat/(id, value)";
        public static string Signature() => " (id,value)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animator), typeof(Function_Animator_SetFloat_id_value));
    }
}
