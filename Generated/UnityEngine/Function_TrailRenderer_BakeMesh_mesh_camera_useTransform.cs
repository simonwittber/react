using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call TrailRenderer.BakeMesh on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_TrailRenderer_BakeMesh_mesh_camera_useTransform : LeafNode
    {
        public UnityEngine.Mesh mesh;
        public UnityEngine.Camera camera;
        public bool useTransform;


        protected UnityEngine.TrailRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.BakeMesh(mesh, camera, useTransform);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.TrailRenderer>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "TrailRenderer.BakeMesh";
        public static string GetMenuPath() => "TrailRenderer/Function/BakeMesh/(mesh, camera, useTransform)";
        public static string Signature() => " (mesh,camera,useTransform)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.TrailRenderer);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.TrailRenderer), typeof(Function_TrailRenderer_BakeMesh_mesh_camera_useTransform));

    }
}
