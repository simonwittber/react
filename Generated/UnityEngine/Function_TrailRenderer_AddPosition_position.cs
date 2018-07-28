using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes method call TrailRenderer.AddPosition on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_TrailRenderer_AddPosition_position : LeafNode
    {
        public UnityEngine.Vector3 position;


        protected UnityEngine.TrailRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.AddPosition(position);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.TrailRenderer>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "TrailRenderer.AddPosition";
        public static string GetMenuPath() => "TrailRenderer/Function/AddPosition";
        public static string Signature() => " (position)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.TrailRenderer);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.TrailRenderer), typeof(Function_TrailRenderer_AddPosition_position));

    }
}
