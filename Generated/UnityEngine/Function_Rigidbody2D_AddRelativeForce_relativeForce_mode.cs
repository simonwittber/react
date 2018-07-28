using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes method call Rigidbody2D.AddRelativeForce on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Rigidbody2D_AddRelativeForce_relativeForce_mode : LeafNode
    {
        public UnityEngine.Vector2 relativeForce;
        public UnityEngine.ForceMode2D mode;


        protected UnityEngine.Rigidbody2D Component { get; set; }

        protected override NodeState Execute() {
            Component.AddRelativeForce(relativeForce, mode);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Rigidbody2D>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Rigidbody2D.AddRelativeForce";
        public static string GetMenuPath() => "Rigidbody2D/Function/AddRelativeForce/(relativeForce, mode)";
        public static string Signature() => " (relativeForce,mode)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody2D);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Rigidbody2D), typeof(Function_Rigidbody2D_AddRelativeForce_relativeForce_mode));

    }
}
