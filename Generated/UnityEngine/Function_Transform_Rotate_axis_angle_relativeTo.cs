using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call Transform.Rotate on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Transform_Rotate_axis_angle_relativeTo : LeafNode
    {
        public UnityEngine.Vector3 axis;
        public float angle;
        public UnityEngine.Space relativeTo;


        protected UnityEngine.Transform Component { get; set; }

        protected override NodeState Execute() {
            Component.Rotate(axis, angle, relativeTo);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Transform>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Transform.Rotate";
        public static string GetMenuPath() => "Transform/Function/Rotate/(axis, angle, relativeTo)";
        public static string Signature() => " (axis,angle,relativeTo)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Transform);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Transform), typeof(Function_Transform_Rotate_axis_angle_relativeTo));

    }
}
