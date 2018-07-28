using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets Renderer.lightProbeProxyVolumeOverride on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Renderer_lightProbeProxyVolumeOverride : LeafNode
    {
        public UnityEngine.GameObject value;

        protected Renderer Component { get; set; }

        protected override NodeState Execute() {
            Component.lightProbeProxyVolumeOverride = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Renderer>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Renderer.lightProbeProxyVolumeOverride";
        public static string GetMenuPath() => "Renderer/Set/lightProbeProxyVolumeOverride";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Renderer);
    }
}
