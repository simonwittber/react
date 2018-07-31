using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Sets SpriteRenderer.sortingLayerName on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_SpriteRenderer_sortingLayerName : LeafNode
    {
        public string value;

        protected SpriteRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.sortingLayerName = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<SpriteRenderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET SpriteRenderer.sortingLayerName";
        public static string GetMenuPath() => "SpriteRenderer/Set/sortingLayerName";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(SpriteRenderer);
    }
}
