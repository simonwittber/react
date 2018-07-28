using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Input.IsJoystickPreconfigured on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Input_IsJoystickPreconfigured_joystickName : LeafNode
    {
        public string joystickName;

        
        protected override NodeState Execute() {
            if(UnityEngine.Input.IsJoystickPreconfigured(joystickName))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Input.IsJoystickPreconfigured";
        public static string GetMenuPath() => "Input/Condition/IsJoystickPreconfigured";
        public static string Signature() => " (joystickName)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
