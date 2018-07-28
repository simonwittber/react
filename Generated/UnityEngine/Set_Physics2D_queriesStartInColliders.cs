using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets Physics2D.queriesStartInColliders on the class to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Physics2D_queriesStartInColliders : LeafNode
    {
        public bool value;

        protected override NodeState Execute() {
            Physics2D.queriesStartInColliders = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Physics2D.queriesStartInColliders";
        public static string GetMenuPath() => "Physics2D/Set/queriesStartInColliders";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Physics2D);
    }
}
