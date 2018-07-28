using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets Physics.sleepThreshold on the class to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Physics_sleepThreshold : LeafNode
    {
        public float value;

        protected override NodeState Execute() {
            Physics.sleepThreshold = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Physics.sleepThreshold";
        public static string GetMenuPath() => "Physics/Set/sleepThreshold";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Physics);
    }
}
