using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes method call Animation.Blend on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Animation_Blend_animation_targetWeight_fadeLength : LeafNode
    {
        public string animation;
        public float targetWeight;
        public float fadeLength;

        protected UnityEngine.Animation Component { get; set; }

        protected override NodeState Execute() {
            Component.Blend(animation, targetWeight, fadeLength);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animation>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Animation.Blend";
        public static string GetMenuPath() => "Animation/Function/Blend/(animation, targetWeight, fadeLength)";
        public static string Signature() => " (animation,targetWeight,fadeLength)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animation);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animation), typeof(Function_Animation_Blend_animation_targetWeight_fadeLength));
    }
}
