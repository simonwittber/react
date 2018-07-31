using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Sets SpriteRenderer.color on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_SpriteRenderer_color : LeafNode
    {
        public UnityEngine.Color value;

        protected SpriteRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.color = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<SpriteRenderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET SpriteRenderer.color";
        public static string GetMenuPath() => "SpriteRenderer/Set/color";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(SpriteRenderer);
    }
}
