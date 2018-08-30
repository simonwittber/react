using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Inventory_HasItem_item : LeafNode
    {
        public string item;

        protected DifferentMethods.React.Components.Inventory Component { get; set; }

        protected override NodeState Execute() {
            if(Component.HasItem(item)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Inventory>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Inventory.HasItem";
        public static string GetMenuPath() => "Inventory/Condition/HasItem/(item)";
        public static string Signature() => " (item)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Inventory);
    }

    
    [System.Serializable]
    public class Not_Condition_Inventory_HasItem_item : LeafNode
    {
        public string item;

        protected DifferentMethods.React.Components.Inventory Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.HasItem(item)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Inventory>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Inventory.HasItem";
        public static string GetMenuPath() => "Inventory/Condition/HasItem/(item)";
        public static string Signature() => " (item)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Inventory);
    }
}
