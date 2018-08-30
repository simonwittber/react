using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Rigidbody2D_AddTorque_torque_mode : LeafNode
    {
        public float torque;
        public UnityEngine.ForceMode2D mode;

        protected UnityEngine.Rigidbody2D Component { get; set; }

        protected override NodeState Execute() {
            Component.AddTorque(torque, mode);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Rigidbody2D>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Rigidbody2D.AddTorque";
        public static string GetMenuPath() => "Rigidbody2D/Function/AddTorque/(torque, mode)";
        public static string Signature() => " (torque,mode)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody2D);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Rigidbody2D), typeof(Function_Rigidbody2D_AddTorque_torque_mode));
    }
}
