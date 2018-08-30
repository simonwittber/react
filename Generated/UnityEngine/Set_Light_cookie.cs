using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Light_cookie : LeafNode
    {
        public UnityEngine.Texture value;

        protected Light Component { get; set; }

        protected override NodeState Execute() {
            Component.cookie = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Light>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Light.cookie";
        public static string GetMenuPath() => "Light/Set/cookie";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Light);
    }
}
