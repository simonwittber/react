using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_SpriteRenderer_flipX : LeafNode
    {
        public bool value;

        protected SpriteRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.flipX = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<SpriteRenderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET SpriteRenderer.flipX";
        public static string GetMenuPath() => "SpriteRenderer/Set/flipX";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(SpriteRenderer);
    }
}
