using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes method call Camera.SetReplacementShader on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Camera_SetReplacementShader_shader_replacementTag : LeafNode
    {
        public UnityEngine.Shader shader;
        public string replacementTag;

        protected UnityEngine.Camera Component { get; set; }

        protected override NodeState Execute() {
            Component.SetReplacementShader(shader, replacementTag);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Camera>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Camera.SetReplacementShader";
        public static string GetMenuPath() => "Camera/Function/SetReplacementShader";
        public static string Signature() => " (shader,replacementTag)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Camera);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Camera), typeof(Function_Camera_SetReplacementShader_shader_replacementTag));
    }
}
