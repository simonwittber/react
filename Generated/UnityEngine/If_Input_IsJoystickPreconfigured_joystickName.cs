using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
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

    
    [System.Serializable]
    public class NotIf_Input_IsJoystickPreconfigured_joystickName : DecoratorNode
    {
        public string joystickName;

        
        protected override NodeState Execute() 
        {
            if(!UnityEngine.Input.IsJoystickPreconfigured(joystickName)) {
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
