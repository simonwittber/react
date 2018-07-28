using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Blackboard.GTE on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Blackboard_GTE_name_value : LeafNode
    {
        public string id;
        public float value;


        DifferentMethods.React.Components.Blackboard Component;

        protected override NodeState Execute() {
            if(Component.GTE(id, value)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = Reactor.GetComponent<DifferentMethods.React.Components.Blackboard>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Blackboard.GTE";
        public static string GetMenuPath() => "Blackboard/Condition/GTE";
        public static string Signature() => " (name,value)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Blackboard);
    }
}
