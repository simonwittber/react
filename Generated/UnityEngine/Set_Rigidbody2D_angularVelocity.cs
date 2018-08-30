using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Rigidbody2D_angularVelocity : LeafNode
    {
        public float value;

        protected Rigidbody2D Component { get; set; }

        protected override NodeState Execute() {
            Component.angularVelocity = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Rigidbody2D>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Rigidbody2D.angularVelocity";
        public static string GetMenuPath() => "Rigidbody2D/Set/angularVelocity";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Rigidbody2D);
    }
}
