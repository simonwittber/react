using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call Inventory.Increment on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Inventory_Increment_item : LeafNode
    {
        public string item;


        DifferentMethods.React.Components.Inventory Component;

        protected override NodeState Execute() {
            Component.Increment(item);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = Reactor.GetComponent<DifferentMethods.React.Components.Inventory>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Inventory.Increment";
        public static string GetMenuPath() => "Inventory/Function/Increment";
        public static string Signature() => " (item)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Inventory);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(DifferentMethods.React.Components.Inventory), typeof(Function_Inventory_Increment_item));

    }
}
