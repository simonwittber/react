using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Collider2D_offset : LeafNode
    {
        public UnityEngine.Vector2 value;

        protected Collider2D Component { get; set; }

        protected override NodeState Execute() {
            Component.offset = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Collider2D>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Collider2D.offset";
        public static string GetMenuPath() => "Collider2D/Set/offset";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Collider2D);
    }
}
