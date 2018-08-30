using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Animator_Play_stateNameHash_layer_normalizedTime : LeafNode
    {
        public int stateNameHash;
        public int layer;
        public float normalizedTime;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.Play(stateNameHash, layer, normalizedTime);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Animator.Play";
        public static string GetMenuPath() => "Animator/Function/Play/(stateNameHash, layer, normalizedTime)";
        public static string Signature() => " (stateNameHash,layer,normalizedTime)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animator), typeof(Function_Animator_Play_stateNameHash_layer_normalizedTime));
    }
}
