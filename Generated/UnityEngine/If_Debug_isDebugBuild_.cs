using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of Debug.isDebugBuild on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Debug_isDebugBuild_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Debug.isDebugBuild) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Debug.isDebugBuild";
        public static string GetMenuPath() => "Debug/If/isDebugBuild";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Debug);
    }
}
