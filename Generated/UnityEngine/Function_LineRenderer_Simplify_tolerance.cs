using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes method call LineRenderer.Simplify on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_LineRenderer_Simplify_tolerance : LeafNode
    {
        public float tolerance;

        protected UnityEngine.LineRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.Simplify(tolerance);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.LineRenderer>();
        public override string ToString() => NiceName();
        public static string NiceName() => "LineRenderer.Simplify";
        public static string GetMenuPath() => "LineRenderer/Function/Simplify";
        public static string Signature() => " (tolerance)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.LineRenderer);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.LineRenderer), typeof(Function_LineRenderer_Simplify_tolerance));
    }
}
