using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Input_GetKeyDown_name : DecoratorNode
    {
        public string id;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Input.GetKeyDown(id)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Input.GetKeyDown";
        public static string GetMenuPath() => "Input/If/GetKeyDown/(name)";
        public static string Signature() => " (name)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }

    
    [System.Serializable]
    public class NotIf_Input_GetKeyDown_name : DecoratorNode
    {
        public string id;

        
        protected override NodeState Execute() 
        {
            if(!UnityEngine.Input.GetKeyDown(id)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Input.GetKeyDown";
        public static string GetMenuPath() => "Input/If/GetKeyDown/(name)";
        public static string Signature() => " (name)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
