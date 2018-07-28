using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Blackboard.GT on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Blackboard_GT_name_value : DecoratorNode
    {
        public string id;
        public float value;


        DifferentMethods.React.Components.Blackboard Component;

        protected override NodeState Execute() 
        {
            if(Component.GT(id, value)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = Reactor.GetComponent<DifferentMethods.React.Components.Blackboard>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Blackboard.GT";
        public static string GetMenuPath() => "Blackboard/If/GT";
        public static string Signature() => " (name,value)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Blackboard);

    }
}
