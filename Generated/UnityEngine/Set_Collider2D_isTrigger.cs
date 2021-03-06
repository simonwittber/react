using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Collider2D_isTrigger : LeafNode
    {
        public bool value;

        protected Collider2D Component { get; set; }

        protected override NodeState Execute() {
            Component.isTrigger = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Collider2D>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Collider2D.isTrigger";
        public static string GetMenuPath() => "Collider2D/Set/isTrigger";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Collider2D);
    }
}
