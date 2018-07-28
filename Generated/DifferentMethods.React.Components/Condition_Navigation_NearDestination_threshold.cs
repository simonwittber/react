using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Navigation.NearDestination on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Navigation_NearDestination_threshold : LeafNode
    {
        public float threshold;


        protected DifferentMethods.React.Components.Navigation Component { get; set; }

        protected override NodeState Execute() {
            if(Component.NearDestination(threshold)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<DifferentMethods.React.Components.Navigation>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Navigation.NearDestination";
        public static string GetMenuPath() => "Navigation/Condition/NearDestination";
        public static string Signature() => " (threshold)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Navigation);
    }
}
