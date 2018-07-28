using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Blackboard.enabled on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Blackboard_enabled_ : DecoratorNode
    {


        protected DifferentMethods.React.Components.Blackboard Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.enabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<DifferentMethods.React.Components.Blackboard>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Blackboard.enabled";
        public static string GetMenuPath() => "Blackboard/If/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Blackboard);

    }
}
