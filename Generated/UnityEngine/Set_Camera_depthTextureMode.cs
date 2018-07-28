using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets Camera.depthTextureMode on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Camera_depthTextureMode : LeafNode
    {
        public UnityEngine.DepthTextureMode value;

        protected Camera Component { get; set; }

        protected override NodeState Execute() {
            Component.depthTextureMode = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Camera>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Camera.depthTextureMode";
        public static string GetMenuPath() => "Camera/Set/depthTextureMode";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Camera);
    }
}
