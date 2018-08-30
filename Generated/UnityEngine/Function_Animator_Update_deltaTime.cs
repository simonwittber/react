using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Animator_Update_deltaTime : LeafNode
    {
        public float deltaTime;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.Update(deltaTime);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Animator.Update";
        public static string GetMenuPath() => "Animator/Function/Update";
        public static string Signature() => " (deltaTime)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animator), typeof(Function_Animator_Update_deltaTime));
    }
}
