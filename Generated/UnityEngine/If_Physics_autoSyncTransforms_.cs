using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Physics_autoSyncTransforms_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Physics.autoSyncTransforms) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics.autoSyncTransforms";
        public static string GetMenuPath() => "Physics/If/autoSyncTransforms";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }

    
    [System.Serializable]
    public class NotIf_Physics_autoSyncTransforms_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(!UnityEngine.Physics.autoSyncTransforms) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics.autoSyncTransforms";
        public static string GetMenuPath() => "Physics/If/autoSyncTransforms";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
