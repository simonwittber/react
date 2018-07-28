using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets Physics.defaultSolverVelocityIterations on the class to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Physics_defaultSolverVelocityIterations : LeafNode
    {
        public int value;

        protected override NodeState Execute() {
            Physics.defaultSolverVelocityIterations = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Physics.defaultSolverVelocityIterations";
        public static string GetMenuPath() => "Physics/Set/defaultSolverVelocityIterations";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Physics);
    }
}
