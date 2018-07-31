using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Sets LineRenderer.textureMode on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_LineRenderer_textureMode : LeafNode
    {
        public UnityEngine.LineTextureMode value;

        protected LineRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.textureMode = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<LineRenderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET LineRenderer.textureMode";
        public static string GetMenuPath() => "LineRenderer/Set/textureMode";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(LineRenderer);
    }
}
