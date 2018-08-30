using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Animator_SetLayerWeight_layerIndex_weight : LeafNode
    {
        public int layerIndex;
        public float weight;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.SetLayerWeight(layerIndex, weight);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Animator.SetLayerWeight";
        public static string GetMenuPath() => "Animator/Function/SetLayerWeight";
        public static string Signature() => " (layerIndex,weight)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animator), typeof(Function_Animator_SetLayerWeight_layerIndex_weight));
    }
}
