using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes method call Transform.LookAt on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Transform_LookAt_worldPosition_worldUp : LeafNode
    {
        public UnityEngine.Vector3 worldPosition;
        public UnityEngine.Vector3 worldUp;

        protected UnityEngine.Transform Component { get; set; }

        protected override NodeState Execute() {
            Component.LookAt(worldPosition, worldUp);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Transform>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Transform.LookAt";
        public static string GetMenuPath() => "Transform/Function/LookAt/(worldPosition, worldUp)";
        public static string Signature() => " (worldPosition,worldUp)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Transform);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Transform), typeof(Function_Transform_LookAt_worldPosition_worldUp));
    }
}
