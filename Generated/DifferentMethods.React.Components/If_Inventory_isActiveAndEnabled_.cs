using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Inventory_isActiveAndEnabled_ : DecoratorNode
    {

        protected DifferentMethods.React.Components.Inventory Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.isActiveAndEnabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Inventory>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Inventory.isActiveAndEnabled";
        public static string GetMenuPath() => "Inventory/If/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Inventory);
    }

    
    [System.Serializable]
    public class Not_If_Inventory_isActiveAndEnabled_ : DecoratorNode
    {

        protected DifferentMethods.React.Components.Inventory Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.isActiveAndEnabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Inventory>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT Inventory.isActiveAndEnabled";
        public static string GetMenuPath() => "Inventory/If/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Inventory);
    }
}
