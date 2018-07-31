using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Sets Camera.renderingPath on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Camera_renderingPath : LeafNode
    {
        public UnityEngine.RenderingPath value;

        protected Camera Component { get; set; }

        protected override NodeState Execute() {
            Component.renderingPath = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Camera>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Camera.renderingPath";
        public static string GetMenuPath() => "Camera/Set/renderingPath";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Camera);
    }
}
