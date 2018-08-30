using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Physics_bounceThreshold : LeafNode
    {
        public float value;

        protected override NodeState Execute() {
            Physics.bounceThreshold = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Physics.bounceThreshold";
        public static string GetMenuPath() => "Physics/Set/bounceThreshold";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Physics);
    }
}
