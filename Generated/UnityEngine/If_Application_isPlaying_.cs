using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Application_isPlaying_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Application.isPlaying) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Application.isPlaying";
        public static string GetMenuPath() => "Application/If/isPlaying";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }

    
    [System.Serializable]
    public class NotIf_Application_isPlaying_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(!UnityEngine.Application.isPlaying) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Application.isPlaying";
        public static string GetMenuPath() => "Application/If/isPlaying";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }
}
