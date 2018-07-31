using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes method call Camera.CopyStereoDeviceProjectionMatrixToNonJittered on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Camera_CopyStereoDeviceProjectionMatrixToNonJittered_eye : LeafNode
    {
        public UnityEngine.Camera.StereoscopicEye eye;

        protected UnityEngine.Camera Component { get; set; }

        protected override NodeState Execute() {
            Component.CopyStereoDeviceProjectionMatrixToNonJittered(eye);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Camera>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Camera.CopyStereoDeviceProjectionMatrixToNonJittered";
        public static string GetMenuPath() => "Camera/Function/CopyStereoDeviceProjectionMatrixToNonJittered";
        public static string Signature() => " (eye)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Camera);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Camera), typeof(Function_Camera_CopyStereoDeviceProjectionMatrixToNonJittered_eye));
    }
}
