using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    
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

    
    [System.Serializable]
    public class Not_If_Navigation_NearDestination_threshold : DecoratorNode
    {
        public float threshold;

        protected DifferentMethods.React.Components.Navigation Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.NearDestination(threshold)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Navigation>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT Navigation.NearDestination";
        public static string GetMenuPath() => "Navigation/If/NearDestination";
        public static string Signature() => " (threshold)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Navigation);
    }
}
