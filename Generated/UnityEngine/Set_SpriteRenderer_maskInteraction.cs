using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_SpriteRenderer_maskInteraction : LeafNode
    {
        public UnityEngine.SpriteMaskInteraction value;

        protected SpriteRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.maskInteraction = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<SpriteRenderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET SpriteRenderer.maskInteraction";
        public static string GetMenuPath() => "SpriteRenderer/Set/maskInteraction";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(SpriteRenderer);
    }
}
