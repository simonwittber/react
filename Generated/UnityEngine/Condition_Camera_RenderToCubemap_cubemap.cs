using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Camera_RenderToCubemap_cubemap : LeafNode
    {
        public UnityEngine.RenderTexture cubemap;

        protected UnityEngine.Camera Component { get; set; }

        protected override NodeState Execute() {
            if(Component.RenderToCubemap(cubemap)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Camera>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Camera.RenderToCubemap";
        public static string GetMenuPath() => "Camera/Condition/RenderToCubemap/(cubemap)";
        public static string Signature() => " (cubemap)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Camera);
    }

    
    [System.Serializable]
    public class Not_Condition_Camera_RenderToCubemap_cubemap : LeafNode
    {
        public UnityEngine.RenderTexture cubemap;

        protected UnityEngine.Camera Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.RenderToCubemap(cubemap)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Camera>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Camera.RenderToCubemap";
        public static string GetMenuPath() => "Camera/Condition/RenderToCubemap/(cubemap)";
        public static string Signature() => " (cubemap)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Camera);
    }
}
