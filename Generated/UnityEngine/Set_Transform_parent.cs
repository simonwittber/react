using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Transform_parent : LeafNode
    {
        public UnityEngine.Transform value;

        protected Transform Component { get; set; }

        protected override NodeState Execute() {
            Component.parent = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Transform>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Transform.parent";
        public static string GetMenuPath() => "Transform/Set/parent";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Transform);
    }
}
