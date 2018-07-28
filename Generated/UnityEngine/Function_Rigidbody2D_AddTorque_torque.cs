using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call Rigidbody2D.AddTorque on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Rigidbody2D_AddTorque_torque : LeafNode
    {
        public float torque;


        protected UnityEngine.Rigidbody2D Component { get; set; }

        protected override NodeState Execute() {
            Component.AddTorque(torque);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Rigidbody2D>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Rigidbody2D.AddTorque";
        public static string GetMenuPath() => "Rigidbody2D/Function/AddTorque/(torque)";
        public static string Signature() => " (torque)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody2D);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Rigidbody2D), typeof(Function_Rigidbody2D_AddTorque_torque));

    }
}
