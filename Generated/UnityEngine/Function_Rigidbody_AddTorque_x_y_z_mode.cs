using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Rigidbody_AddTorque_x_y_z_mode : LeafNode
    {
        public float x;
        public float y;
        public float z;
        public UnityEngine.ForceMode mode;

        protected UnityEngine.Rigidbody Component { get; set; }

        protected override NodeState Execute() {
            Component.AddTorque(x, y, z, mode);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Rigidbody>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Rigidbody.AddTorque";
        public static string GetMenuPath() => "Rigidbody/Function/AddTorque/(x, y, z, mode)";
        public static string Signature() => " (x,y,z,mode)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Rigidbody), typeof(Function_Rigidbody_AddTorque_x_y_z_mode));
    }
}
