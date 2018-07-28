using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call Blackboard.Mul on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Blackboard_Mul_name_value : LeafNode
    {
        public string id;
        public float value;


        DifferentMethods.React.Components.Blackboard Component;

        protected override NodeState Execute() {
            Component.Mul(id, value);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = Reactor.GetComponent<DifferentMethods.React.Components.Blackboard>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Blackboard.Mul";
        public static string GetMenuPath() => "Blackboard/Function/Mul";
        public static string Signature() => " (name,value)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Blackboard);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(DifferentMethods.React.Components.Blackboard), typeof(Function_Blackboard_Mul_name_value));

    }
}
