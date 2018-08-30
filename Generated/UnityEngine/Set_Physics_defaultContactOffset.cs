using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Physics_defaultContactOffset : LeafNode
    {
        public float value;

        protected override NodeState Execute() {
            Physics.defaultContactOffset = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Physics.defaultContactOffset";
        public static string GetMenuPath() => "Physics/Set/defaultContactOffset";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Physics);
    }
}
