using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets Inventory.enabled on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Inventory_enabled : LeafNode
    {
        public bool value;

        Inventory Component;

        protected override NodeState Execute() {
            Component.enabled = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = Reactor.GetComponent<Inventory>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Inventory.enabled";
        public static string GetMenuPath() => "Inventory/Set/enabled";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Inventory);
    }
}
