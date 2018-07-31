using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes method call Transform.Rotate on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Transform_Rotate_eulers : LeafNode
    {
        public UnityEngine.Vector3 eulers;

        protected UnityEngine.Transform Component { get; set; }

        protected override NodeState Execute() {
            Component.Rotate(eulers);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Transform>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Transform.Rotate";
        public static string GetMenuPath() => "Transform/Function/Rotate/(eulers)";
        public static string Signature() => " (eulers)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Transform);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Transform), typeof(Function_Transform_Rotate_eulers));
    }
}
