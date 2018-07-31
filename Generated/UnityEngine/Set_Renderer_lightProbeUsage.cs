using DifferentMethods.React;
using UnityEngine;
using UnityEngine.Rendering;


namespace React.Generated {
    /// <summary>
    /// Sets Renderer.lightProbeUsage on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Renderer_lightProbeUsage : LeafNode
    {
        public UnityEngine.Rendering.LightProbeUsage value;

        protected Renderer Component { get; set; }

        protected override NodeState Execute() {
            Component.lightProbeUsage = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Renderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Renderer.lightProbeUsage";
        public static string GetMenuPath() => "Renderer/Set/lightProbeUsage";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Renderer);
    }
}
