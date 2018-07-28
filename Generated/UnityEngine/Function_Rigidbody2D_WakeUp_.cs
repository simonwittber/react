using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes method call Rigidbody2D.WakeUp on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Rigidbody2D_WakeUp_ : LeafNode
    {


        protected UnityEngine.Rigidbody2D Component { get; set; }

        protected override NodeState Execute() {
            Component.WakeUp();
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Rigidbody2D>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Rigidbody2D.WakeUp";
        public static string GetMenuPath() => "Rigidbody2D/Function/WakeUp";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody2D);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Rigidbody2D), typeof(Function_Rigidbody2D_WakeUp_));

    }
}
