using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets Physics.autoSimulation on the class to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Physics_autoSimulation : LeafNode
    {
        public bool value;

        protected override NodeState Execute() {
            Physics.autoSimulation = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Physics.autoSimulation";
        public static string GetMenuPath() => "Physics/Set/autoSimulation";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Physics);
    }
}
