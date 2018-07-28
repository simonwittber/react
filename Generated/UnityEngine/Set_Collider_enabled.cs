using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets Collider.enabled on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Collider_enabled : LeafNode
    {
        public bool value;

        protected Collider Component { get; set; }

        protected override NodeState Execute() {
            Component.enabled = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Collider>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Collider.enabled";
        public static string GetMenuPath() => "Collider/Set/enabled";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Collider);
    }
}
