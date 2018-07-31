using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Input.GetButtonDown on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Input_GetButtonDown_buttonName : LeafNode
    {
        public string buttonName;

        
        protected override NodeState Execute() {
            if(UnityEngine.Input.GetButtonDown(buttonName))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Input.GetButtonDown";
        public static string GetMenuPath() => "Input/Condition/GetButtonDown";
        public static string Signature() => " (buttonName)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
