using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Physics2D_maxAngularCorrection : LeafNode
    {
        public float value;

        protected override NodeState Execute() {
            Physics2D.maxAngularCorrection = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Physics2D.maxAngularCorrection";
        public static string GetMenuPath() => "Physics2D/Set/maxAngularCorrection";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Physics2D);
    }
}
