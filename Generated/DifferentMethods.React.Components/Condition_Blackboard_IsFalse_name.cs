using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Blackboard.IsFalse on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Blackboard_IsFalse_name : LeafNode
    {
        public string id;


        DifferentMethods.React.Components.Blackboard Component;

        protected override NodeState Execute() {
            if(Component.IsFalse(id)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = Reactor.GetComponent<DifferentMethods.React.Components.Blackboard>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Blackboard.IsFalse";
        public static string GetMenuPath() => "Blackboard/Condition/IsFalse";
        public static string Signature() => " (name)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Blackboard);
    }
}