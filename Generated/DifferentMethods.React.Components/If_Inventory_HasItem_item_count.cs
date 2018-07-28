using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Inventory.HasItem on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Inventory_HasItem_item_count : DecoratorNode
    {
        public string item;
        public int count;


        DifferentMethods.React.Components.Inventory Component;

        protected override NodeState Execute() 
        {
            if(Component.HasItem(item, count)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = Reactor.GetComponent<DifferentMethods.React.Components.Inventory>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Inventory.HasItem";
        public static string GetMenuPath() => "Inventory/If/HasItem/(item, count)";
        public static string Signature() => " (item,count)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Inventory);

    }
}
