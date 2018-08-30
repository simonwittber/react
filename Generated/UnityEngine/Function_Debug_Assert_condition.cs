using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    [System.Serializable]
    
    public class Function_Debug_Assert_condition : LeafNode
    {
        public bool condition;

        
        protected override NodeState Execute() {
            UnityEngine.Debug.Assert(condition);
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Debug.Assert";
        public static string GetMenuPath() => "Debug/Function/Assert/(condition)";
        public static string Signature() => " (condition)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Debug);
    }
}
