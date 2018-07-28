using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Target.ChooseRandomTarget on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Target_ChooseRandomTarget_ : DecoratorNode
    {


        DifferentMethods.React.Components.Target Component;

        protected override NodeState Execute() 
        {
            if(Component.ChooseRandomTarget()) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = Reactor.GetComponent<DifferentMethods.React.Components.Target>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Target.ChooseRandomTarget";
        public static string GetMenuPath() => "Target/If/ChooseRandomTarget";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Target);

    }
}
