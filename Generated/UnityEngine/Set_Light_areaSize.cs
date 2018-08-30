using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Light_areaSize : LeafNode
    {
        public UnityEngine.Vector2 value;

        protected Light Component { get; set; }

        protected override NodeState Execute() {
            Component.areaSize = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Light>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Light.areaSize";
        public static string GetMenuPath() => "Light/Set/areaSize";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Light);
    }
}
