using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Sets Light.lightmapBakeType on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Light_lightmapBakeType : LeafNode
    {
        public UnityEngine.LightmapBakeType value;

        protected Light Component { get; set; }

        protected override NodeState Execute() {
            Component.lightmapBakeType = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Light>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Light.lightmapBakeType";
        public static string GetMenuPath() => "Light/Set/lightmapBakeType";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Light);
    }
}
