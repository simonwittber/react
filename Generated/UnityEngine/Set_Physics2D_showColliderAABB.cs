using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Sets Physics2D.showColliderAABB on the class to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Physics2D_showColliderAABB : LeafNode
    {
        public bool value;

        protected override NodeState Execute() {
            Physics2D.showColliderAABB = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Physics2D.showColliderAABB";
        public static string GetMenuPath() => "Physics2D/Set/showColliderAABB";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Physics2D);
    }
}
