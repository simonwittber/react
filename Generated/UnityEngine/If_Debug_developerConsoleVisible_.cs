using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Debug_developerConsoleVisible_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Debug.developerConsoleVisible) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Debug.developerConsoleVisible";
        public static string GetMenuPath() => "Debug/If/developerConsoleVisible";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Debug);
    }

    
    [System.Serializable]
    public class NotIf_Debug_developerConsoleVisible_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(!UnityEngine.Debug.developerConsoleVisible) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Debug.developerConsoleVisible";
        public static string GetMenuPath() => "Debug/If/developerConsoleVisible";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Debug);
    }
}
