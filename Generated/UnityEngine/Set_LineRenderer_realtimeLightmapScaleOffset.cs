using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_LineRenderer_realtimeLightmapScaleOffset : LeafNode
    {
        public UnityEngine.Vector4 value;

        protected LineRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.realtimeLightmapScaleOffset = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<LineRenderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET LineRenderer.realtimeLightmapScaleOffset";
        public static string GetMenuPath() => "LineRenderer/Set/realtimeLightmapScaleOffset";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(LineRenderer);
    }
}
