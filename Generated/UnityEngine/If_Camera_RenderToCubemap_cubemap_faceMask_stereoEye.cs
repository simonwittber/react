using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Camera_RenderToCubemap_cubemap_faceMask_stereoEye : DecoratorNode
    {
        public UnityEngine.RenderTexture cubemap;
        public int faceMask;
        public UnityEngine.Camera.MonoOrStereoscopicEye stereoEye;

        protected UnityEngine.Camera Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.RenderToCubemap(cubemap, faceMask, stereoEye)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Camera>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Camera.RenderToCubemap";
        public static string GetMenuPath() => "Camera/If/RenderToCubemap/(cubemap, faceMask, stereoEye)";
        public static string Signature() => " (cubemap,faceMask,stereoEye)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Camera);
    }

    
    [System.Serializable]
    public class Not_If_Camera_RenderToCubemap_cubemap_faceMask_stereoEye : DecoratorNode
    {
        public UnityEngine.RenderTexture cubemap;
        public int faceMask;
        public UnityEngine.Camera.MonoOrStereoscopicEye stereoEye;

        protected UnityEngine.Camera Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.RenderToCubemap(cubemap, faceMask, stereoEye)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Camera>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT Camera.RenderToCubemap";
        public static string GetMenuPath() => "Camera/If/RenderToCubemap/(cubemap, faceMask, stereoEye)";
        public static string Signature() => " (cubemap,faceMask,stereoEye)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Camera);
    }
}
