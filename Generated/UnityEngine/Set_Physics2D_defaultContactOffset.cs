using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Physics2D_defaultContactOffset : LeafNode
    {
        public float value;

        protected override NodeState Execute() {
            Physics2D.defaultContactOffset = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Physics2D.defaultContactOffset";
        public static string GetMenuPath() => "Physics2D/Set/defaultContactOffset";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Physics2D);
    }
}
