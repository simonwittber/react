using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Physics2D_velocityThreshold : LeafNode
    {
        public float value;

        protected override NodeState Execute() {
            Physics2D.velocityThreshold = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Physics2D.velocityThreshold";
        public static string GetMenuPath() => "Physics2D/Set/velocityThreshold";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Physics2D);
    }
}
