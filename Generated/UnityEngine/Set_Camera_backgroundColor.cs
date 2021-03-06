using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Camera_backgroundColor : LeafNode
    {
        public UnityEngine.Color value;

        protected Camera Component { get; set; }

        protected override NodeState Execute() {
            Component.backgroundColor = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Camera>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Camera.backgroundColor";
        public static string GetMenuPath() => "Camera/Set/backgroundColor";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Camera);
    }
}
