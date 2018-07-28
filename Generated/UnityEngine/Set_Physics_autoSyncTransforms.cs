using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets Physics.autoSyncTransforms on the class to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Physics_autoSyncTransforms : LeafNode
    {
        public bool value;

        protected override NodeState Execute() {
            Physics.autoSyncTransforms = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Physics.autoSyncTransforms";
        public static string GetMenuPath() => "Physics/Set/autoSyncTransforms";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Physics);
    }
}
