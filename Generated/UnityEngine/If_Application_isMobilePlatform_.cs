using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Application_isMobilePlatform_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Application.isMobilePlatform) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Application.isMobilePlatform";
        public static string GetMenuPath() => "Application/If/isMobilePlatform";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }

    
    [System.Serializable]
    public class NotIf_Application_isMobilePlatform_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(!UnityEngine.Application.isMobilePlatform) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Application.isMobilePlatform";
        public static string GetMenuPath() => "Application/If/isMobilePlatform";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }
}
