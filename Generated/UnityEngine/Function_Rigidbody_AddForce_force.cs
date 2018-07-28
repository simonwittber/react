using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes method call Rigidbody.AddForce on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Rigidbody_AddForce_force : LeafNode
    {
        public UnityEngine.Vector3 force;


        protected UnityEngine.Rigidbody Component { get; set; }

        protected override NodeState Execute() {
            Component.AddForce(force);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Rigidbody>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Rigidbody.AddForce";
        public static string GetMenuPath() => "Rigidbody/Function/AddForce/(force)";
        public static string Signature() => " (force)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Rigidbody), typeof(Function_Rigidbody_AddForce_force));

    }
}
