using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes method call TrailRenderer.Clear on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_TrailRenderer_Clear_ : LeafNode
    {


        protected UnityEngine.TrailRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.Clear();
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.TrailRenderer>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "TrailRenderer.Clear";
        public static string GetMenuPath() => "TrailRenderer/Function/Clear";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.TrailRenderer);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.TrailRenderer), typeof(Function_TrailRenderer_Clear_));

    }
}
