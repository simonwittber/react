using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes method call Blackboard.Add on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Blackboard_Add_name_value : LeafNode
    {
        public string id;
        public float value;

        protected DifferentMethods.React.Components.Blackboard Component { get; set; }

        protected override NodeState Execute() {
            Component.Add(id, value);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Blackboard>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Blackboard.Add";
        public static string GetMenuPath() => "Blackboard/Function/Add";
        public static string Signature() => " (name,value)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Blackboard);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(DifferentMethods.React.Components.Blackboard), typeof(Function_Blackboard_Add_name_value));
    }
}
