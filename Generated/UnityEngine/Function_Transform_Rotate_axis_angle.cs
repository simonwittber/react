using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Transform_Rotate_axis_angle : LeafNode
    {
        public UnityEngine.Vector3 axis;
        public float angle;

        protected UnityEngine.Transform Component { get; set; }

        protected override NodeState Execute() {
            Component.Rotate(axis, angle);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Transform>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Transform.Rotate";
        public static string GetMenuPath() => "Transform/Function/Rotate/(axis, angle)";
        public static string Signature() => " (axis,angle)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Transform);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Transform), typeof(Function_Transform_Rotate_axis_angle));
    }
}
