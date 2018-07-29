using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets LineRenderer.alignment on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_LineRenderer_alignment : LeafNode
    {
        public UnityEngine.LineAlignment value;

        protected LineRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.alignment = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<LineRenderer>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET LineRenderer.alignment";
        public static string GetMenuPath() => "LineRenderer/Set/alignment";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(LineRenderer);
    }
}
