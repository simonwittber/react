using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Blackboard.enabled on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Blackboard_enabled_ : LeafNode
    {


        protected DifferentMethods.React.Components.Blackboard Component { get; set; }

        protected override NodeState Execute() {
            if(Component.enabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<DifferentMethods.React.Components.Blackboard>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Blackboard.enabled";
        public static string GetMenuPath() => "Blackboard/Condition/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Blackboard);
    }
}
