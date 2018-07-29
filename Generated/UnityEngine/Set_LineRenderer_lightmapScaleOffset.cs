using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets LineRenderer.lightmapScaleOffset on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_LineRenderer_lightmapScaleOffset : LeafNode
    {
        public UnityEngine.Vector4 value;

        protected LineRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.lightmapScaleOffset = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<LineRenderer>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET LineRenderer.lightmapScaleOffset";
        public static string GetMenuPath() => "LineRenderer/Set/lightmapScaleOffset";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(LineRenderer);
    }
}
