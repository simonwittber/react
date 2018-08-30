using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Camera_RenderWithShader_shader_replacementTag : LeafNode
    {
        public UnityEngine.Shader shader;
        public string replacementTag;

        protected UnityEngine.Camera Component { get; set; }

        protected override NodeState Execute() {
            Component.RenderWithShader(shader, replacementTag);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Camera>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Camera.RenderWithShader";
        public static string GetMenuPath() => "Camera/Function/RenderWithShader";
        public static string Signature() => " (shader,replacementTag)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Camera);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Camera), typeof(Function_Camera_RenderWithShader_shader_replacementTag));
    }
}
