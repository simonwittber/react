using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of Inventory.HasItem on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Inventory_HasItem_item : DecoratorNode
    {
        public string item;

        protected DifferentMethods.React.Components.Inventory Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.HasItem(item)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Inventory>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Inventory.HasItem";
        public static string GetMenuPath() => "Inventory/If/HasItem/(item)";
        public static string Signature() => " (item)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Inventory);
    }
}
