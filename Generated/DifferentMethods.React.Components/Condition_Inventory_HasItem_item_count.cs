using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Inventory.HasItem on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Inventory_HasItem_item_count : LeafNode
    {
        public string item;
        public int count;


        DifferentMethods.React.Components.Inventory Component;

        protected override NodeState Execute() {
            if(Component.HasItem(item, count)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = Reactor.GetComponent<DifferentMethods.React.Components.Inventory>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Inventory.HasItem";
        public static string GetMenuPath() => "Inventory/Condition/HasItem/(item, count)";
        public static string Signature() => " (item,count)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Inventory);
    }
}
