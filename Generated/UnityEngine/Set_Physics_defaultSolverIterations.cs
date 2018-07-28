using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets Physics.defaultSolverIterations on the class to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Physics_defaultSolverIterations : LeafNode
    {
        public int value;

        protected override NodeState Execute() {
            Physics.defaultSolverIterations = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Physics.defaultSolverIterations";
        public static string GetMenuPath() => "Physics/Set/defaultSolverIterations";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Physics);
    }
}
