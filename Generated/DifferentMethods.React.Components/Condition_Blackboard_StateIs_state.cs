using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Blackboard_StateIs_state : LeafNode
    {
        public string state;

        protected DifferentMethods.React.Components.Blackboard Component { get; set; }

        protected override NodeState Execute() {
            if(Component.StateIs(state)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Blackboard>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Blackboard.StateIs";
        public static string GetMenuPath() => "Blackboard/Condition/StateIs";
        public static string Signature() => " (state)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Blackboard);
    }

    
    [System.Serializable]
    public class Not_Condition_Blackboard_StateIs_state : LeafNode
    {
        public string state;

        protected DifferentMethods.React.Components.Blackboard Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.StateIs(state)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Blackboard>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Blackboard.StateIs";
        public static string GetMenuPath() => "Blackboard/Condition/StateIs";
        public static string Signature() => " (state)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Blackboard);
    }
}
