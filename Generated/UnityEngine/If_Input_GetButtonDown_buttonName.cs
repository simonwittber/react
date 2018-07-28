using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Input.GetButtonDown on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Input_GetButtonDown_buttonName : DecoratorNode
    {
        public string buttonName;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Input.GetButtonDown(buttonName)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Input.GetButtonDown";
        public static string GetMenuPath() => "Input/If/GetButtonDown";
        public static string Signature() => " (buttonName)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}