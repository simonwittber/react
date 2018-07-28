using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call Debug.Assert on the class, then returns a NoResult state.
    /// </summary>
    [System.Serializable]
    
    public class Function_Debug_Assert_condition : LeafNode
    {
        public bool condition;

        
        protected override NodeState Execute() {
            UnityEngine.Debug.Assert(condition);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Debug.Assert";
        public static string GetMenuPath() => "Debug/Function/Assert/(condition)";
        public static string Signature() => " (condition)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Debug);
    }
}
