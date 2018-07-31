using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of Physics2D.Simulate on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Physics2D_Simulate_step : DecoratorNode
    {
        public float step;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Physics2D.Simulate(step)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics2D.Simulate";
        public static string GetMenuPath() => "Physics2D/If/Simulate";
        public static string Signature() => " (step)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics2D);
    }
}
