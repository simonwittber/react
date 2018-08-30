using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Animator_SetInteger_name_value : LeafNode
    {
        public string id;
        public int value;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.SetInteger(id, value);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Animator.SetInteger";
        public static string GetMenuPath() => "Animator/Function/SetInteger/(name, value)";
        public static string Signature() => " (name,value)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animator), typeof(Function_Animator_SetInteger_name_value));
    }
}
