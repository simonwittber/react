using DifferentMethods.React;
using UnityEngine;
using UnityEngine.Rendering;


namespace React.Generated {
    /// <summary>
    /// Sets TrailRenderer.shadowCastingMode on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_TrailRenderer_shadowCastingMode : LeafNode
    {
        public UnityEngine.Rendering.ShadowCastingMode value;

        protected TrailRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.shadowCastingMode = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<TrailRenderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET TrailRenderer.shadowCastingMode";
        public static string GetMenuPath() => "TrailRenderer/Set/shadowCastingMode";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(TrailRenderer);
    }
}
