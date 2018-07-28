using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Blackboard.isActiveAndEnabled on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Blackboard_isActiveAndEnabled_ : DecoratorNode
    {


        DifferentMethods.React.Components.Blackboard Component;

        protected override NodeState Execute() 
        {
            if(Component.isActiveAndEnabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = Reactor.GetComponent<DifferentMethods.React.Components.Blackboard>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Blackboard.isActiveAndEnabled";
        public static string GetMenuPath() => "Blackboard/If/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Blackboard);

    }
}
