using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Debug.developerConsoleVisible on the class is true.
    /// </summary>
    
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

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Debug.developerConsoleVisible";
        public static string GetMenuPath() => "Debug/If/developerConsoleVisible";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Debug);
    }
}
