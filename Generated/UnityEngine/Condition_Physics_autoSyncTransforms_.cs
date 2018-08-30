using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Physics_autoSyncTransforms_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics.autoSyncTransforms)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Physics.autoSyncTransforms";
        public static string GetMenuPath() => "Physics/Condition/autoSyncTransforms";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }

    
    [System.Serializable]
    public class Not_Condition_Physics_autoSyncTransforms_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics.autoSyncTransforms)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Physics.autoSyncTransforms";
        public static string GetMenuPath() => "Physics/Condition/autoSyncTransforms";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
