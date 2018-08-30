using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Rigidbody_constraints : LeafNode
    {
        public UnityEngine.RigidbodyConstraints value;

        protected Rigidbody Component { get; set; }

        protected override NodeState Execute() {
            Component.constraints = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Rigidbody>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Rigidbody.constraints";
        public static string GetMenuPath() => "Rigidbody/Set/constraints";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Rigidbody);
    }
}
