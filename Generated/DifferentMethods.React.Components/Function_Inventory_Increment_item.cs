using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Inventory_Increment_item : LeafNode
    {
        public string item;

        protected DifferentMethods.React.Components.Inventory Component { get; set; }

        protected override NodeState Execute() {
            Component.Increment(item);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Inventory>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Inventory.Increment";
        public static string GetMenuPath() => "Inventory/Function/Increment";
        public static string Signature() => " (item)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Inventory);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(DifferentMethods.React.Components.Inventory), typeof(Function_Inventory_Increment_item));
    }
}
