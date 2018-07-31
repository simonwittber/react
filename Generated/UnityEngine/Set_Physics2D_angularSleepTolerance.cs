using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Sets Physics2D.angularSleepTolerance on the class to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Physics2D_angularSleepTolerance : LeafNode
    {
        public float value;

        protected override NodeState Execute() {
            Physics2D.angularSleepTolerance = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Physics2D.angularSleepTolerance";
        public static string GetMenuPath() => "Physics2D/Set/angularSleepTolerance";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Physics2D);
    }
}
