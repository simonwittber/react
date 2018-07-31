using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Camera.RenderToCubemap on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Camera_RenderToCubemap_cubemap_faceMask : LeafNode
    {
        public UnityEngine.RenderTexture cubemap;
        public int faceMask;

        protected UnityEngine.Camera Component { get; set; }

        protected override NodeState Execute() {
            if(Component.RenderToCubemap(cubemap, faceMask)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Camera>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Camera.RenderToCubemap";
        public static string GetMenuPath() => "Camera/Condition/RenderToCubemap/(cubemap, faceMask)";
        public static string Signature() => " (cubemap,faceMask)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Camera);
    }
}
