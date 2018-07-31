using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes method call Transform.RotateAround on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Transform_RotateAround_point_axis_angle : LeafNode
    {
        public UnityEngine.Vector3 point;
        public UnityEngine.Vector3 axis;
        public float angle;

        protected UnityEngine.Transform Component { get; set; }

        protected override NodeState Execute() {
            Component.RotateAround(point, axis, angle);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Transform>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Transform.RotateAround";
        public static string GetMenuPath() => "Transform/Function/RotateAround/(point, axis, angle)";
        public static string Signature() => " (point,axis,angle)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Transform);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Transform), typeof(Function_Transform_RotateAround_point_axis_angle));
    }
}
