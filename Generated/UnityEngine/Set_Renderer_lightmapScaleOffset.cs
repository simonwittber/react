using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Sets Renderer.lightmapScaleOffset on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Renderer_lightmapScaleOffset : LeafNode
    {
        public UnityEngine.Vector4 value;

        protected Renderer Component { get; set; }

        protected override NodeState Execute() {
            Component.lightmapScaleOffset = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Renderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Renderer.lightmapScaleOffset";
        public static string GetMenuPath() => "Renderer/Set/lightmapScaleOffset";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Renderer);
    }
}
