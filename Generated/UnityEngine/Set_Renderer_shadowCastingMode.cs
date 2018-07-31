using DifferentMethods.React;
using UnityEngine;
using UnityEngine.Rendering;


namespace React.Generated {
    /// <summary>
    /// Sets Renderer.shadowCastingMode on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Renderer_shadowCastingMode : LeafNode
    {
        public UnityEngine.Rendering.ShadowCastingMode value;

        protected Renderer Component { get; set; }

        protected override NodeState Execute() {
            Component.shadowCastingMode = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Renderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Renderer.shadowCastingMode";
        public static string GetMenuPath() => "Renderer/Set/shadowCastingMode";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Renderer);
    }
}
