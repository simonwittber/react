using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Sets Collider.contactOffset on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Collider_contactOffset : LeafNode
    {
        public float value;

        protected Collider Component { get; set; }

        protected override NodeState Execute() {
            Component.contactOffset = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Collider>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Collider.contactOffset";
        public static string GetMenuPath() => "Collider/Set/contactOffset";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Collider);
    }
}
