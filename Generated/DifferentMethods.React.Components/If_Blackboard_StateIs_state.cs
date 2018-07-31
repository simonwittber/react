using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of Blackboard.StateIs on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Blackboard_StateIs_state : DecoratorNode
    {
        public string state;

        protected DifferentMethods.React.Components.Blackboard Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.StateIs(state)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Blackboard>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Blackboard.StateIs";
        public static string GetMenuPath() => "Blackboard/If/StateIs";
        public static string Signature() => " (state)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Blackboard);
    }
}
