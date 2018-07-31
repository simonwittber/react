using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of Application.HasUserAuthorization on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Application_HasUserAuthorization_mode : DecoratorNode
    {
        public UnityEngine.UserAuthorization mode;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Application.HasUserAuthorization(mode)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Application.HasUserAuthorization";
        public static string GetMenuPath() => "Application/If/HasUserAuthorization";
        public static string Signature() => " (mode)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }
}
