using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Camera_transparencySortAxis : LeafNode
    {
        public UnityEngine.Vector3 value;

        protected Camera Component { get; set; }

        protected override NodeState Execute() {
            Component.transparencySortAxis = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Camera>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Camera.transparencySortAxis";
        public static string GetMenuPath() => "Camera/Set/transparencySortAxis";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Camera);
    }
}
