using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets LineRenderer.startColor on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_LineRenderer_startColor : LeafNode
    {
        public UnityEngine.Color value;

        protected LineRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.startColor = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<LineRenderer>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET LineRenderer.startColor";
        public static string GetMenuPath() => "LineRenderer/Set/startColor";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(LineRenderer);
    }
}
