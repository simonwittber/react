using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Navigation_MoveTowardsActiveTarget_speed : LeafNode
    {
        public float speed;

        protected DifferentMethods.React.Components.Navigation Component { get; set; }

        protected override NodeState Execute() {
            Component.MoveTowardsActiveTarget(speed);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Navigation>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Navigation.MoveTowardsActiveTarget";
        public static string GetMenuPath() => "Navigation/Function/MoveTowardsActiveTarget";
        public static string Signature() => " (speed)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Navigation);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(DifferentMethods.React.Components.Navigation), typeof(Function_Navigation_MoveTowardsActiveTarget_speed));
    }
}
