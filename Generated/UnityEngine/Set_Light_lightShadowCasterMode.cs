using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets Light.lightShadowCasterMode on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Light_lightShadowCasterMode : LeafNode
    {
        public UnityEngine.LightShadowCasterMode value;

        protected Light Component { get; set; }

        protected override NodeState Execute() {
            Component.lightShadowCasterMode = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Light>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Light.lightShadowCasterMode";
        public static string GetMenuPath() => "Light/Set/lightShadowCasterMode";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Light);
    }
}
