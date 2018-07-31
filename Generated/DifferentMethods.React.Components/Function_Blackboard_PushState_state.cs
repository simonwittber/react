using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes method call Blackboard.PushState on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Blackboard_PushState_state : LeafNode
    {
        public string state;

        protected DifferentMethods.React.Components.Blackboard Component { get; set; }

        protected override NodeState Execute() {
            Component.PushState(state);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Blackboard>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Blackboard.PushState";
        public static string GetMenuPath() => "Blackboard/Function/PushState";
        public static string Signature() => " (state)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Blackboard);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(DifferentMethods.React.Components.Blackboard), typeof(Function_Blackboard_PushState_state));
    }
}
