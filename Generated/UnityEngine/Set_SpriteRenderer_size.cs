using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Sets SpriteRenderer.size on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_SpriteRenderer_size : LeafNode
    {
        public UnityEngine.Vector2 value;

        protected SpriteRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.size = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<SpriteRenderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET SpriteRenderer.size";
        public static string GetMenuPath() => "SpriteRenderer/Set/size";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(SpriteRenderer);
    }
}
