using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Sets Physics.interCollisionStiffness on the class to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Physics_interCollisionStiffness : LeafNode
    {
        public float value;

        protected override NodeState Execute() {
            Physics.interCollisionStiffness = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Physics.interCollisionStiffness";
        public static string GetMenuPath() => "Physics/Set/interCollisionStiffness";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Physics);
    }
}
