using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets Renderer.realtimeLightmapScaleOffset on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Renderer_realtimeLightmapScaleOffset : LeafNode
    {
        public UnityEngine.Vector4 value;

        protected Renderer Component { get; set; }

        protected override NodeState Execute() {
            Component.realtimeLightmapScaleOffset = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Renderer>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Renderer.realtimeLightmapScaleOffset";
        public static string GetMenuPath() => "Renderer/Set/realtimeLightmapScaleOffset";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Renderer);
    }
}
