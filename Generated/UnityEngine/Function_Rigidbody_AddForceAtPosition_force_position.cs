using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes method call Rigidbody.AddForceAtPosition on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Rigidbody_AddForceAtPosition_force_position : LeafNode
    {
        public UnityEngine.Vector3 force;
        public UnityEngine.Vector3 position;

        protected UnityEngine.Rigidbody Component { get; set; }

        protected override NodeState Execute() {
            Component.AddForceAtPosition(force, position);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Rigidbody>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Rigidbody.AddForceAtPosition";
        public static string GetMenuPath() => "Rigidbody/Function/AddForceAtPosition/(force, position)";
        public static string Signature() => " (force,position)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Rigidbody), typeof(Function_Rigidbody_AddForceAtPosition_force_position));
    }
}
