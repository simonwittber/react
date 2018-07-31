using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of Input.anyKeyDown on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Input_anyKeyDown_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Input.anyKeyDown) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Input.anyKeyDown";
        public static string GetMenuPath() => "Input/If/anyKeyDown";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
