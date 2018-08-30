using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_SpriteRenderer_lightProbeProxyVolumeOverride : LeafNode
    {
        public UnityEngine.GameObject value;

        protected SpriteRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.lightProbeProxyVolumeOverride = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<SpriteRenderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET SpriteRenderer.lightProbeProxyVolumeOverride";
        public static string GetMenuPath() => "SpriteRenderer/Set/lightProbeProxyVolumeOverride";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(SpriteRenderer);
    }
}
