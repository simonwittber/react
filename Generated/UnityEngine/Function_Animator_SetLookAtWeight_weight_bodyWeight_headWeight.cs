using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Animator_SetLookAtWeight_weight_bodyWeight_headWeight : LeafNode
    {
        public float weight;
        public float bodyWeight;
        public float headWeight;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.SetLookAtWeight(weight, bodyWeight, headWeight);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Animator.SetLookAtWeight";
        public static string GetMenuPath() => "Animator/Function/SetLookAtWeight/(weight, bodyWeight, headWeight)";
        public static string Signature() => " (weight,bodyWeight,headWeight)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animator), typeof(Function_Animator_SetLookAtWeight_weight_bodyWeight_headWeight));
    }
}
