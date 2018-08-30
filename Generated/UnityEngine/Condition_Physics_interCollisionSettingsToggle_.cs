using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Physics_interCollisionSettingsToggle_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics.interCollisionSettingsToggle)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Physics.interCollisionSettingsToggle";
        public static string GetMenuPath() => "Physics/Condition/interCollisionSettingsToggle";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }

    
    [System.Serializable]
    public class Not_Condition_Physics_interCollisionSettingsToggle_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics.interCollisionSettingsToggle)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Physics.interCollisionSettingsToggle";
        public static string GetMenuPath() => "Physics/Condition/interCollisionSettingsToggle";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
