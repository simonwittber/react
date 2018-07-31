using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of Input.GetMouseButton on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Input_GetMouseButton_button : DecoratorNode
    {
        public int button;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Input.GetMouseButton(button)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Input.GetMouseButton";
        public static string GetMenuPath() => "Input/If/GetMouseButton";
        public static string Signature() => " (button)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
