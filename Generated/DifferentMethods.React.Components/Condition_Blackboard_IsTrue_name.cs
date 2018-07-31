using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Blackboard.IsTrue on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Blackboard_IsTrue_name : LeafNode
    {
        public string id;

        protected DifferentMethods.React.Components.Blackboard Component { get; set; }

        protected override NodeState Execute() {
            if(Component.IsTrue(id)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Blackboard>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Blackboard.IsTrue";
        public static string GetMenuPath() => "Blackboard/Condition/IsTrue";
        public static string Signature() => " (name)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Blackboard);
    }
}
