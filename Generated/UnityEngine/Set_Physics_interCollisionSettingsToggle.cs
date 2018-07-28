using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets Physics.interCollisionSettingsToggle on the class to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Physics_interCollisionSettingsToggle : LeafNode
    {
        public bool value;

        protected override NodeState Execute() {
            Physics.interCollisionSettingsToggle = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Physics.interCollisionSettingsToggle";
        public static string GetMenuPath() => "Physics/Set/interCollisionSettingsToggle";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Physics);
    }
}
