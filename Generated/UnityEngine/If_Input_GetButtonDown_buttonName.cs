using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
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

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Input.GetButtonDown";
        public static string GetMenuPath() => "Input/If/GetButtonDown";
        public static string Signature() => " (buttonName)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }

    
    [System.Serializable]
    public class NotIf_Input_GetButtonDown_buttonName : DecoratorNode
    {
        public string buttonName;

        
        protected override NodeState Execute() 
        {
            if(!UnityEngine.Input.GetButtonDown(buttonName)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Input.GetButtonDown";
        public static string GetMenuPath() => "Input/If/GetButtonDown";
        public static string Signature() => " (buttonName)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
