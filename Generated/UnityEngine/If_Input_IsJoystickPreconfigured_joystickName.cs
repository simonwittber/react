using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of Input.IsJoystickPreconfigured on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Input_IsJoystickPreconfigured_joystickName : DecoratorNode
    {
        public string joystickName;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Input.IsJoystickPreconfigured(joystickName)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Input.IsJoystickPreconfigured";
        public static string GetMenuPath() => "Input/If/IsJoystickPreconfigured";
        public static string Signature() => " (joystickName)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
