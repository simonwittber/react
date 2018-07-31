using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of Navigation.NearDestination on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Navigation_NearDestination_threshold : DecoratorNode
    {
        public float threshold;

        protected DifferentMethods.React.Components.Navigation Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.NearDestination(threshold)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Navigation>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Navigation.NearDestination";
        public static string GetMenuPath() => "Navigation/If/NearDestination";
        public static string Signature() => " (threshold)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Navigation);
    }
}
