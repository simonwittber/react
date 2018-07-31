using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Sets Rigidbody.isKinematic on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Rigidbody_isKinematic : LeafNode
    {
        public bool value;

        protected Rigidbody Component { get; set; }

        protected override NodeState Execute() {
            Component.isKinematic = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Rigidbody>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Rigidbody.isKinematic";
        public static string GetMenuPath() => "Rigidbody/Set/isKinematic";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Rigidbody);
    }
}
