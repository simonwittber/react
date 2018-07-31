using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of Blackboard.IsFalse on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Blackboard_IsFalse_name : DecoratorNode
    {
        public string id;

        protected DifferentMethods.React.Components.Blackboard Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.IsFalse(id)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Blackboard>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Blackboard.IsFalse";
        public static string GetMenuPath() => "Blackboard/If/IsFalse";
        public static string Signature() => " (name)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Blackboard);
    }
}
