using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Animator_SetBool_id_value : LeafNode
    {
        public int id;
        public bool value;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.SetBool(id, value);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Animator.SetBool";
        public static string GetMenuPath() => "Animator/Function/SetBool/(id, value)";
        public static string Signature() => " (id,value)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animator), typeof(Function_Animator_SetBool_id_value));
    }
}
