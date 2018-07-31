using DifferentMethods.React;
using UnityEngine;
using UnityEngine.Rendering;


namespace React.Generated {
    /// <summary>
    /// Executes method call Camera.RemoveCommandBuffers on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Camera_RemoveCommandBuffers_evt : LeafNode
    {
        public UnityEngine.Rendering.CameraEvent evt;

        protected UnityEngine.Camera Component { get; set; }

        protected override NodeState Execute() {
            Component.RemoveCommandBuffers(evt);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Camera>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Camera.RemoveCommandBuffers";
        public static string GetMenuPath() => "Camera/Function/RemoveCommandBuffers";
        public static string Signature() => " (evt)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Camera);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Camera), typeof(Function_Camera_RemoveCommandBuffers_evt));
    }
}
