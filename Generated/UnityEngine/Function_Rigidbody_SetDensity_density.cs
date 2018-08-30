using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Rigidbody_SetDensity_density : LeafNode
    {
        public float density;

        protected UnityEngine.Rigidbody Component { get; set; }

        protected override NodeState Execute() {
            Component.SetDensity(density);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Rigidbody>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Rigidbody.SetDensity";
        public static string GetMenuPath() => "Rigidbody/Function/SetDensity";
        public static string Signature() => " (density)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Rigidbody), typeof(Function_Rigidbody_SetDensity_density));
    }
}
