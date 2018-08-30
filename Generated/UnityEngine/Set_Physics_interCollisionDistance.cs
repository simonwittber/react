using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Physics_interCollisionDistance : LeafNode
    {
        public float value;

        protected override NodeState Execute() {
            Physics.interCollisionDistance = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Physics.interCollisionDistance";
        public static string GetMenuPath() => "Physics/Set/interCollisionDistance";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Physics);
    }
}
