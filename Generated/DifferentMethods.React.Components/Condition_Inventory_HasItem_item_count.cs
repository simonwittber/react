using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Inventory_HasItem_item_count : LeafNode
    {
        public string item;
        public int count;

        protected DifferentMethods.React.Components.Inventory Component { get; set; }

        protected override NodeState Execute() {
            if(Component.HasItem(item, count)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Inventory>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Inventory.HasItem";
        public static string GetMenuPath() => "Inventory/Condition/HasItem/(item, count)";
        public static string Signature() => " (item,count)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Inventory);
    }

    
    [System.Serializable]
    public class Not_Condition_Inventory_HasItem_item_count : LeafNode
    {
        public string item;
        public int count;

        protected DifferentMethods.React.Components.Inventory Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.HasItem(item, count)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Inventory>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Inventory.HasItem";
        public static string GetMenuPath() => "Inventory/Condition/HasItem/(item, count)";
        public static string Signature() => " (item,count)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Inventory);
    }
}
