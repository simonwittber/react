using DifferentMethods.React;
using UnityEngine;
using UnityEngine.Rendering;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_LineRenderer_shadowCastingMode : LeafNode
    {
        public UnityEngine.Rendering.ShadowCastingMode value;

        protected LineRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.shadowCastingMode = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<LineRenderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET LineRenderer.shadowCastingMode";
        public static string GetMenuPath() => "LineRenderer/Set/shadowCastingMode";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(LineRenderer);
    }
}
