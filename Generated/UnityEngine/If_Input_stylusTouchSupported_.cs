using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of Input.stylusTouchSupported on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Input_stylusTouchSupported_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Input.stylusTouchSupported) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Input.stylusTouchSupported";
        public static string GetMenuPath() => "Input/If/stylusTouchSupported";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
