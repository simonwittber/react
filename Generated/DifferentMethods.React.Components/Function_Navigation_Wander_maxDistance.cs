using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call Navigation.Wander on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Navigation_Wander_maxDistance : LeafNode
    {
        public float maxDistance;


        protected DifferentMethods.React.Components.Navigation Component { get; set; }

        protected override NodeState Execute() {
            Component.Wander(maxDistance);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<DifferentMethods.React.Components.Navigation>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Navigation.Wander";
        public static string GetMenuPath() => "Navigation/Function/Wander";
        public static string Signature() => " (maxDistance)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Navigation);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(DifferentMethods.React.Components.Navigation), typeof(Function_Navigation_Wander_maxDistance));

    }
}
