using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_LineRenderer_lightProbeProxyVolumeOverride : LeafNode
    {
        public UnityEngine.GameObject value;

        protected LineRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.lightProbeProxyVolumeOverride = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<LineRenderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET LineRenderer.lightProbeProxyVolumeOverride";
        public static string GetMenuPath() => "LineRenderer/Set/lightProbeProxyVolumeOverride";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(LineRenderer);
    }
}
