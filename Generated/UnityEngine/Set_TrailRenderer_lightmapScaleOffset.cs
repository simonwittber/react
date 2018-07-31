using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Sets TrailRenderer.lightmapScaleOffset on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_TrailRenderer_lightmapScaleOffset : LeafNode
    {
        public UnityEngine.Vector4 value;

        protected TrailRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.lightmapScaleOffset = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<TrailRenderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET TrailRenderer.lightmapScaleOffset";
        public static string GetMenuPath() => "TrailRenderer/Set/lightmapScaleOffset";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(TrailRenderer);
    }
}
