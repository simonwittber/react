using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of Input.simulateMouseWithTouches on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Input_simulateMouseWithTouches_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Input.simulateMouseWithTouches) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Input.simulateMouseWithTouches";
        public static string GetMenuPath() => "Input/If/simulateMouseWithTouches";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
