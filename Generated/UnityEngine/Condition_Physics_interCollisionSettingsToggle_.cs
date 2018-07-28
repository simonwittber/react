using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Physics.interCollisionSettingsToggle on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Physics_interCollisionSettingsToggle_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics.interCollisionSettingsToggle)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Physics.interCollisionSettingsToggle";
        public static string GetMenuPath() => "Physics/Condition/interCollisionSettingsToggle";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
