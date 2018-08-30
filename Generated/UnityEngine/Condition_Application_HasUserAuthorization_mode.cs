using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Application_HasUserAuthorization_mode : LeafNode
    {
        public UnityEngine.UserAuthorization mode;

        
        protected override NodeState Execute() {
            if(UnityEngine.Application.HasUserAuthorization(mode))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Application.HasUserAuthorization";
        public static string GetMenuPath() => "Application/Condition/HasUserAuthorization";
        public static string Signature() => " (mode)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }

    
    [System.Serializable]
    public class Not_Condition_Application_HasUserAuthorization_mode : LeafNode
    {
        public UnityEngine.UserAuthorization mode;

        
        protected override NodeState Execute() {
            if(UnityEngine.Application.HasUserAuthorization(mode))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Application.HasUserAuthorization";
        public static string GetMenuPath() => "Application/Condition/HasUserAuthorization";
        public static string Signature() => " (mode)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }
}
