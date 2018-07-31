using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of Input.backButtonLeavesApp on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Input_backButtonLeavesApp_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Input.backButtonLeavesApp) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Input.backButtonLeavesApp";
        public static string GetMenuPath() => "Input/If/backButtonLeavesApp";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
