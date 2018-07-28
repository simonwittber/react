using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call Animator.SetLookAtWeight on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Animator_SetLookAtWeight_weight_bodyWeight_headWeight_eyesWeight : LeafNode
    {
        public float weight;
        public float bodyWeight;
        public float headWeight;
        public float eyesWeight;


        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.SetLookAtWeight(weight, bodyWeight, headWeight, eyesWeight);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Animator>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Animator.SetLookAtWeight";
        public static string GetMenuPath() => "Animator/Function/SetLookAtWeight/(weight, bodyWeight, headWeight, eyesWeight)";
        public static string Signature() => " (weight,bodyWeight,headWeight,eyesWeight)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animator), typeof(Function_Animator_SetLookAtWeight_weight_bodyWeight_headWeight_eyesWeight));

    }
}
