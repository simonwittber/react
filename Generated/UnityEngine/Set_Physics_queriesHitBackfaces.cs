using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Sets Physics.queriesHitBackfaces on the class to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Physics_queriesHitBackfaces : LeafNode
    {
        public bool value;

        protected override NodeState Execute() {
            Physics.queriesHitBackfaces = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Physics.queriesHitBackfaces";
        public static string GetMenuPath() => "Physics/Set/queriesHitBackfaces";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Physics);
    }
}
