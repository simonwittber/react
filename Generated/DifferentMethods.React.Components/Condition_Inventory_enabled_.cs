using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Inventory.enabled on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Inventory_enabled_ : LeafNode
    {


        DifferentMethods.React.Components.Inventory Component;

        protected override NodeState Execute() {
            if(Component.enabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = Reactor.GetComponent<DifferentMethods.React.Components.Inventory>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Inventory.enabled";
        public static string GetMenuPath() => "Inventory/Condition/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Inventory);
    }
}
