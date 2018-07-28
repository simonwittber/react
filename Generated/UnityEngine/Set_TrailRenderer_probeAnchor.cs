using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets TrailRenderer.probeAnchor on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_TrailRenderer_probeAnchor : LeafNode
    {
        public UnityEngine.Transform value;

        protected TrailRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.probeAnchor = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<TrailRenderer>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET TrailRenderer.probeAnchor";
        public static string GetMenuPath() => "TrailRenderer/Set/probeAnchor";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(TrailRenderer);
    }
}
