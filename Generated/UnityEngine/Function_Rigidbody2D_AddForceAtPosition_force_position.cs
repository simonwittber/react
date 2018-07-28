using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes method call Rigidbody2D.AddForceAtPosition on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Rigidbody2D_AddForceAtPosition_force_position : LeafNode
    {
        public UnityEngine.Vector2 force;
        public UnityEngine.Vector2 position;


        protected UnityEngine.Rigidbody2D Component { get; set; }

        protected override NodeState Execute() {
            Component.AddForceAtPosition(force, position);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Rigidbody2D>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Rigidbody2D.AddForceAtPosition";
        public static string GetMenuPath() => "Rigidbody2D/Function/AddForceAtPosition/(force, position)";
        public static string Signature() => " (force,position)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody2D);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Rigidbody2D), typeof(Function_Rigidbody2D_AddForceAtPosition_force_position));

    }
}
