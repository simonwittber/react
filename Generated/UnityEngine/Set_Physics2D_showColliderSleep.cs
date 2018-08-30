using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Physics2D_showColliderSleep : LeafNode
    {
        public bool value;

        protected override NodeState Execute() {
            Physics2D.showColliderSleep = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Physics2D.showColliderSleep";
        public static string GetMenuPath() => "Physics2D/Set/showColliderSleep";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Physics2D);
    }
}
