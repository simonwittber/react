using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Rigidbody_AddRelativeTorque_x_y_z : LeafNode
    {
        public float x;
        public float y;
        public float z;

        protected UnityEngine.Rigidbody Component { get; set; }

        protected override NodeState Execute() {
            Component.AddRelativeTorque(x, y, z);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Rigidbody>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Rigidbody.AddRelativeTorque";
        public static string GetMenuPath() => "Rigidbody/Function/AddRelativeTorque/(x, y, z)";
        public static string Signature() => " (x,y,z)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Rigidbody), typeof(Function_Rigidbody_AddRelativeTorque_x_y_z));
    }
}
