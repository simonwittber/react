using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_TrailRenderer_endColor : LeafNode
    {
        public UnityEngine.Color value;

        protected TrailRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.endColor = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<TrailRenderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET TrailRenderer.endColor";
        public static string GetMenuPath() => "TrailRenderer/Set/endColor";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(TrailRenderer);
    }
}
