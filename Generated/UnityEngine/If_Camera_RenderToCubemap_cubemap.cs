using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Camera.RenderToCubemap on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Camera_RenderToCubemap_cubemap : DecoratorNode
    {
        public UnityEngine.RenderTexture cubemap;


        protected UnityEngine.Camera Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.RenderToCubemap(cubemap)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Camera>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Camera.RenderToCubemap";
        public static string GetMenuPath() => "Camera/If/RenderToCubemap/(cubemap)";
        public static string Signature() => " (cubemap)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Camera);

    }
}
