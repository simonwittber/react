using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Sets SpriteRenderer.drawMode on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_SpriteRenderer_drawMode : LeafNode
    {
        public UnityEngine.SpriteDrawMode value;

        protected SpriteRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.drawMode = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<SpriteRenderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET SpriteRenderer.drawMode";
        public static string GetMenuPath() => "SpriteRenderer/Set/drawMode";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(SpriteRenderer);
    }
}
