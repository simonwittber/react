using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Blackboard.GT on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Blackboard_GT_name_value : LeafNode
    {
        public string id;
        public float value;


        protected DifferentMethods.React.Components.Blackboard Component { get; set; }

        protected override NodeState Execute() {
            if(Component.GT(id, value)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<DifferentMethods.React.Components.Blackboard>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Blackboard.GT";
        public static string GetMenuPath() => "Blackboard/Condition/GT";
        public static string Signature() => " (name,value)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Blackboard);
    }
}
