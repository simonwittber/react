using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets LineRenderer.endColor on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_LineRenderer_endColor : LeafNode
    {
        public UnityEngine.Color value;

        protected LineRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.endColor = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<LineRenderer>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET LineRenderer.endColor";
        public static string GetMenuPath() => "LineRenderer/Set/endColor";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(LineRenderer);
    }
}
