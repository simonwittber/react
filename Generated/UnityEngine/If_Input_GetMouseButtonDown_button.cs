using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Input_GetMouseButtonDown_button : DecoratorNode
    {
        public int button;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Input.GetMouseButtonDown(button)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Input.GetMouseButtonDown";
        public static string GetMenuPath() => "Input/If/GetMouseButtonDown";
        public static string Signature() => " (button)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }

    
    [System.Serializable]
    public class NotIf_Input_GetMouseButtonDown_button : DecoratorNode
    {
        public int button;

        
        protected override NodeState Execute() 
        {
            if(!UnityEngine.Input.GetMouseButtonDown(button)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Input.GetMouseButtonDown";
        public static string GetMenuPath() => "Input/If/GetMouseButtonDown";
        public static string Signature() => " (button)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
