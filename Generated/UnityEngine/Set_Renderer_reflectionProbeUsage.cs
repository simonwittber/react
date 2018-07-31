using DifferentMethods.React;
using UnityEngine;
using UnityEngine.Rendering;


namespace React.Generated {
    /// <summary>
    /// Sets Renderer.reflectionProbeUsage on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Renderer_reflectionProbeUsage : LeafNode
    {
        public UnityEngine.Rendering.ReflectionProbeUsage value;

        protected Renderer Component { get; set; }

        protected override NodeState Execute() {
            Component.reflectionProbeUsage = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Renderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Renderer.reflectionProbeUsage";
        public static string GetMenuPath() => "Renderer/Set/reflectionProbeUsage";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Renderer);
    }
}
