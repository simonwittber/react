using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Light_flare : LeafNode
    {
        public UnityEngine.Flare value;

        protected Light Component { get; set; }

        protected override NodeState Execute() {
            Component.flare = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Light>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Light.flare";
        public static string GetMenuPath() => "Light/Set/flare";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Light);
    }
}
