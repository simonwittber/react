using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets Light.renderMode on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Light_renderMode : LeafNode
    {
        public UnityEngine.LightRenderMode value;

        protected Light Component { get; set; }

        protected override NodeState Execute() {
            Component.renderMode = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Light>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Light.renderMode";
        public static string GetMenuPath() => "Light/Set/renderMode";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Light);
    }
}
