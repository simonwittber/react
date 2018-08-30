using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Transform_position : LeafNode
    {
        public UnityEngine.Vector3 value;

        protected Transform Component { get; set; }

        protected override NodeState Execute() {
            Component.position = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Transform>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Transform.position";
        public static string GetMenuPath() => "Transform/Set/position";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Transform);
    }
}
