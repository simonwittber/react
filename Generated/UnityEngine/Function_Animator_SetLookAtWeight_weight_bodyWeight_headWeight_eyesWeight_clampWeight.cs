using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes method call Animator.SetLookAtWeight on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Animator_SetLookAtWeight_weight_bodyWeight_headWeight_eyesWeight_clampWeight : LeafNode
    {
        public float weight;
        public float bodyWeight;
        public float headWeight;
        public float eyesWeight;
        public float clampWeight;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.SetLookAtWeight(weight, bodyWeight, headWeight, eyesWeight, clampWeight);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Animator.SetLookAtWeight";
        public static string GetMenuPath() => "Animator/Function/SetLookAtWeight/(weight, bodyWeight, headWeight, eyesWeight, clampWeight)";
        public static string Signature() => " (weight,bodyWeight,headWeight,eyesWeight,clampWeight)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animator), typeof(Function_Animator_SetLookAtWeight_weight_bodyWeight_headWeight_eyesWeight_clampWeight));
    }
}
