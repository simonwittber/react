using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Target.ChooseFurthestTarget on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Target_ChooseFurthestTarget_ : DecoratorNode
    {


        protected DifferentMethods.React.Components.Target Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.ChooseFurthestTarget()) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<DifferentMethods.React.Components.Target>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Target.ChooseFurthestTarget";
        public static string GetMenuPath() => "Target/If/ChooseFurthestTarget";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Target);

    }
}
