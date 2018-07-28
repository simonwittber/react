using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call TrailRenderer.BakeMesh on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_TrailRenderer_BakeMesh_mesh_useTransform : LeafNode
    {
        public UnityEngine.Mesh mesh;
        public bool useTransform;


        protected UnityEngine.TrailRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.BakeMesh(mesh, useTransform);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.TrailRenderer>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "TrailRenderer.BakeMesh";
        public static string GetMenuPath() => "TrailRenderer/Function/BakeMesh/(mesh, useTransform)";
        public static string Signature() => " (mesh,useTransform)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.TrailRenderer);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.TrailRenderer), typeof(Function_TrailRenderer_BakeMesh_mesh_useTransform));

    }
}
