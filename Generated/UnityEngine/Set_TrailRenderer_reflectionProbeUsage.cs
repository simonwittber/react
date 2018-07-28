using DifferentMethods.React;
using UnityEngine;
using UnityEngine.Rendering;


namespace React.Generated {

    /// <summary>
    /// Sets TrailRenderer.reflectionProbeUsage on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_TrailRenderer_reflectionProbeUsage : LeafNode
    {
        public UnityEngine.Rendering.ReflectionProbeUsage value;

        protected TrailRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.reflectionProbeUsage = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<TrailRenderer>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET TrailRenderer.reflectionProbeUsage";
        public static string GetMenuPath() => "TrailRenderer/Set/reflectionProbeUsage";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(TrailRenderer);
    }
}
