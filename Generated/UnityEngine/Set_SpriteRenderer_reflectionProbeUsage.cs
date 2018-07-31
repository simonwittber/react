using DifferentMethods.React;
using UnityEngine;
using UnityEngine.Rendering;


namespace React.Generated {
    /// <summary>
    /// Sets SpriteRenderer.reflectionProbeUsage on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_SpriteRenderer_reflectionProbeUsage : LeafNode
    {
        public UnityEngine.Rendering.ReflectionProbeUsage value;

        protected SpriteRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.reflectionProbeUsage = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<SpriteRenderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET SpriteRenderer.reflectionProbeUsage";
        public static string GetMenuPath() => "SpriteRenderer/Set/reflectionProbeUsage";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(SpriteRenderer);
    }
}
