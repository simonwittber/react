using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Physics2D_Simulate_step : LeafNode
    {
        public float step;

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics2D.Simulate(step))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Physics2D.Simulate";
        public static string GetMenuPath() => "Physics2D/Condition/Simulate";
        public static string Signature() => " (step)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics2D);
    }

    
    [System.Serializable]
    public class Not_Condition_Physics2D_Simulate_step : LeafNode
    {
        public float step;

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics2D.Simulate(step))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Physics2D.Simulate";
        public static string GetMenuPath() => "Physics2D/Condition/Simulate";
        public static string Signature() => " (step)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics2D);
    }
}
