using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Animation_Blend_animation : LeafNode
    {
        public string animation;

        protected UnityEngine.Animation Component { get; set; }

        protected override NodeState Execute() {
            Component.Blend(animation);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animation>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Animation.Blend";
        public static string GetMenuPath() => "Animation/Function/Blend/(animation)";
        public static string Signature() => " (animation)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animation);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animation), typeof(Function_Animation_Blend_animation));
    }
}
