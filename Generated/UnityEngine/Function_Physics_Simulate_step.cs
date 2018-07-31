using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes method call Physics.Simulate on the class, then returns a NoResult state.
    /// </summary>
    [System.Serializable]
    
    public class Function_Physics_Simulate_step : LeafNode
    {
        public float step;

        
        protected override NodeState Execute() {
            UnityEngine.Physics.Simulate(step);
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Physics.Simulate";
        public static string GetMenuPath() => "Physics/Function/Simulate";
        public static string Signature() => " (step)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
