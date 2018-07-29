using DifferentMethods.React;
using UnityEngine;
using UnityEngine.Rendering;


namespace React.Generated {

    /// <summary>
    /// Sets SpriteRenderer.shadowCastingMode on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_SpriteRenderer_shadowCastingMode : LeafNode
    {
        public UnityEngine.Rendering.ShadowCastingMode value;

        protected SpriteRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.shadowCastingMode = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<SpriteRenderer>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET SpriteRenderer.shadowCastingMode";
        public static string GetMenuPath() => "SpriteRenderer/Set/shadowCastingMode";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(SpriteRenderer);
    }
}
