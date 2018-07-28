using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets Collider.isTrigger on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Collider_isTrigger : LeafNode
    {
        public bool value;

        protected Collider Component { get; set; }

        protected override NodeState Execute() {
            Component.isTrigger = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Collider>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Collider.isTrigger";
        public static string GetMenuPath() => "Collider/Set/isTrigger";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Collider);
    }
}
