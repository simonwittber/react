using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Sets SpriteRenderer.sprite on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_SpriteRenderer_sprite : LeafNode
    {
        public UnityEngine.Sprite value;

        protected SpriteRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.sprite = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<SpriteRenderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET SpriteRenderer.sprite";
        public static string GetMenuPath() => "SpriteRenderer/Set/sprite";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(SpriteRenderer);
    }
}
