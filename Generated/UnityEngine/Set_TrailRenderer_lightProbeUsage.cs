using DifferentMethods.React;
using UnityEngine;
using UnityEngine.Rendering;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_TrailRenderer_lightProbeUsage : LeafNode
    {
        public UnityEngine.Rendering.LightProbeUsage value;

        protected TrailRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.lightProbeUsage = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<TrailRenderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET TrailRenderer.lightProbeUsage";
        public static string GetMenuPath() => "TrailRenderer/Set/lightProbeUsage";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(TrailRenderer);
    }
}
