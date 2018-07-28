using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets TrailRenderer.realtimeLightmapScaleOffset on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_TrailRenderer_realtimeLightmapScaleOffset : LeafNode
    {
        public UnityEngine.Vector4 value;

        protected TrailRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.realtimeLightmapScaleOffset = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<TrailRenderer>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET TrailRenderer.realtimeLightmapScaleOffset";
        public static string GetMenuPath() => "TrailRenderer/Set/realtimeLightmapScaleOffset";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(TrailRenderer);
    }
}
