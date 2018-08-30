using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_TrailRenderer_textureMode : LeafNode
    {
        public UnityEngine.LineTextureMode value;

        protected TrailRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.textureMode = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<TrailRenderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET TrailRenderer.textureMode";
        public static string GetMenuPath() => "TrailRenderer/Set/textureMode";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(TrailRenderer);
    }
}
