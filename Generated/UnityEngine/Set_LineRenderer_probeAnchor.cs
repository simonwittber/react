using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Sets LineRenderer.probeAnchor on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_LineRenderer_probeAnchor : LeafNode
    {
        public UnityEngine.Transform value;

        protected LineRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.probeAnchor = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<LineRenderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET LineRenderer.probeAnchor";
        public static string GetMenuPath() => "LineRenderer/Set/probeAnchor";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(LineRenderer);
    }
}
