using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets SpriteRenderer.lightmapScaleOffset on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_SpriteRenderer_lightmapScaleOffset : LeafNode
    {
        public UnityEngine.Vector4 value;

        protected SpriteRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.lightmapScaleOffset = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<SpriteRenderer>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET SpriteRenderer.lightmapScaleOffset";
        public static string GetMenuPath() => "SpriteRenderer/Set/lightmapScaleOffset";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(SpriteRenderer);
    }
}
