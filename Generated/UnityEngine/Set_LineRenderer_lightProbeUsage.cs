using DifferentMethods.React;
using UnityEngine;
using UnityEngine.Rendering;


namespace React.Generated {

    /// <summary>
    /// Sets LineRenderer.lightProbeUsage on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_LineRenderer_lightProbeUsage : LeafNode
    {
        public UnityEngine.Rendering.LightProbeUsage value;

        protected LineRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.lightProbeUsage = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<LineRenderer>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET LineRenderer.lightProbeUsage";
        public static string GetMenuPath() => "LineRenderer/Set/lightProbeUsage";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(LineRenderer);
    }
}
