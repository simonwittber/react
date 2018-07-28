using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes method call Rigidbody2D.AddForce on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Rigidbody2D_AddForce_force : LeafNode
    {
        public UnityEngine.Vector2 force;


        protected UnityEngine.Rigidbody2D Component { get; set; }

        protected override NodeState Execute() {
            Component.AddForce(force);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Rigidbody2D>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Rigidbody2D.AddForce";
        public static string GetMenuPath() => "Rigidbody2D/Function/AddForce/(force)";
        public static string Signature() => " (force)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody2D);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Rigidbody2D), typeof(Function_Rigidbody2D_AddForce_force));

    }
}
