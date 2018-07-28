using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Inventory.isActiveAndEnabled on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Inventory_isActiveAndEnabled_ : DecoratorNode
    {


        DifferentMethods.React.Components.Inventory Component;

        protected override NodeState Execute() 
        {
            if(Component.isActiveAndEnabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = Reactor.GetComponent<DifferentMethods.React.Components.Inventory>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Inventory.isActiveAndEnabled";
        public static string GetMenuPath() => "Inventory/If/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Inventory);

    }
}
