using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Rigidbody_detectCollisions : LeafNode
    {
        public bool value;

        protected Rigidbody Component { get; set; }

        protected override NodeState Execute() {
            Component.detectCollisions = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Rigidbody>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Rigidbody.detectCollisions";
        public static string GetMenuPath() => "Rigidbody/Set/detectCollisions";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Rigidbody);
    }
}
