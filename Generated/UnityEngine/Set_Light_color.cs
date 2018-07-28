using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets Light.color on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Light_color : LeafNode
    {
        public UnityEngine.Color value;

        protected Light Component { get; set; }

        protected override NodeState Execute() {
            Component.color = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Light>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Light.color";
        public static string GetMenuPath() => "Light/Set/color";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Light);
    }
}
