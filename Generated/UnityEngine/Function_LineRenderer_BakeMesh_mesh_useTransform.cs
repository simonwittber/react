using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes method call LineRenderer.BakeMesh on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_LineRenderer_BakeMesh_mesh_useTransform : LeafNode
    {
        public UnityEngine.Mesh mesh;
        public bool useTransform;

        protected UnityEngine.LineRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.BakeMesh(mesh, useTransform);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.LineRenderer>();
        public override string ToString() => NiceName();
        public static string NiceName() => "LineRenderer.BakeMesh";
        public static string GetMenuPath() => "LineRenderer/Function/BakeMesh/(mesh, useTransform)";
        public static string Signature() => " (mesh,useTransform)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.LineRenderer);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.LineRenderer), typeof(Function_LineRenderer_BakeMesh_mesh_useTransform));
    }
}
