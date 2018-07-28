using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets Physics.queriesHitTriggers on the class to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Physics_queriesHitTriggers : LeafNode
    {
        public bool value;

        protected override NodeState Execute() {
            Physics.queriesHitTriggers = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Physics.queriesHitTriggers";
        public static string GetMenuPath() => "Physics/Set/queriesHitTriggers";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Physics);
    }
}
