using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Blackboard.EQ on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Blackboard_EQ_name_value_epsilon : LeafNode
    {
        public string id;
        public float value;
        public float epsilon;


        protected DifferentMethods.React.Components.Blackboard Component { get; set; }

        protected override NodeState Execute() {
            if(Component.EQ(id, value, epsilon)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<DifferentMethods.React.Components.Blackboard>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Blackboard.EQ";
        public static string GetMenuPath() => "Blackboard/Condition/EQ";
        public static string Signature() => " (name,value,epsilon)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Blackboard);
    }
}
