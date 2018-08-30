using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Rigidbody2D_AddForceAtPosition_force_position_mode : LeafNode
    {
        public UnityEngine.Vector2 force;
        public UnityEngine.Vector2 position;
        public UnityEngine.ForceMode2D mode;

        protected UnityEngine.Rigidbody2D Component { get; set; }

        protected override NodeState Execute() {
            Component.AddForceAtPosition(force, position, mode);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Rigidbody2D>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Rigidbody2D.AddForceAtPosition";
        public static string GetMenuPath() => "Rigidbody2D/Function/AddForceAtPosition/(force, position, mode)";
        public static string Signature() => " (force,position,mode)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody2D);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Rigidbody2D), typeof(Function_Rigidbody2D_AddForceAtPosition_force_position_mode));
    }
}
