using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes method call Rigidbody.AddRelativeTorque on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Rigidbody_AddRelativeTorque_torque_mode : LeafNode
    {
        public UnityEngine.Vector3 torque;
        public UnityEngine.ForceMode mode;

        protected UnityEngine.Rigidbody Component { get; set; }

        protected override NodeState Execute() {
            Component.AddRelativeTorque(torque, mode);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Rigidbody>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Rigidbody.AddRelativeTorque";
        public static string GetMenuPath() => "Rigidbody/Function/AddRelativeTorque/(torque, mode)";
        public static string Signature() => " (torque,mode)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Rigidbody), typeof(Function_Rigidbody_AddRelativeTorque_torque_mode));
    }
}
