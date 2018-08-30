using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_TrailRenderer_startColor : LeafNode
    {
        public UnityEngine.Color value;

        protected TrailRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.startColor = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<TrailRenderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET TrailRenderer.startColor";
        public static string GetMenuPath() => "TrailRenderer/Set/startColor";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(TrailRenderer);
    }
}
