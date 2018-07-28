using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes method call Camera.CopyFrom on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Camera_CopyFrom_other : LeafNode
    {
        public UnityEngine.Camera other;


        protected UnityEngine.Camera Component { get; set; }

        protected override NodeState Execute() {
            Component.CopyFrom(other);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Camera>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Camera.CopyFrom";
        public static string GetMenuPath() => "Camera/Function/CopyFrom";
        public static string Signature() => " (other)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Camera);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Camera), typeof(Function_Camera_CopyFrom_other));

    }
}
