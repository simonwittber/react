using DifferentMethods.React;
using UnityEngine;
using UnityEngine.Rendering;


namespace React.Generated {
    /// <summary>
    /// Sets Light.shadowResolution on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Light_shadowResolution : LeafNode
    {
        public UnityEngine.Rendering.LightShadowResolution value;

        protected Light Component { get; set; }

        protected override NodeState Execute() {
            Component.shadowResolution = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Light>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Light.shadowResolution";
        public static string GetMenuPath() => "Light/Set/shadowResolution";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Light);
    }
}
