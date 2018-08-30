using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Physics2D_alwaysShowColliders : LeafNode
    {
        public bool value;

        protected override NodeState Execute() {
            Physics2D.alwaysShowColliders = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Physics2D.alwaysShowColliders";
        public static string GetMenuPath() => "Physics2D/Set/alwaysShowColliders";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Physics2D);
    }
}
