using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Rigidbody2D_useFullKinematicContacts : LeafNode
    {
        public bool value;

        protected Rigidbody2D Component { get; set; }

        protected override NodeState Execute() {
            Component.useFullKinematicContacts = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Rigidbody2D>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Rigidbody2D.useFullKinematicContacts";
        public static string GetMenuPath() => "Rigidbody2D/Set/useFullKinematicContacts";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Rigidbody2D);
    }
}
