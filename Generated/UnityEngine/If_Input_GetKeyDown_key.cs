using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Input_GetKeyDown_key : DecoratorNode
    {
        public UnityEngine.KeyCode key;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Input.GetKeyDown(key)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Input.GetKeyDown";
        public static string GetMenuPath() => "Input/If/GetKeyDown/(key)";
        public static string Signature() => " (key)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }

    
    [System.Serializable]
    public class NotIf_Input_GetKeyDown_key : DecoratorNode
    {
        public UnityEngine.KeyCode key;

        
        protected override NodeState Execute() 
        {
            if(!UnityEngine.Input.GetKeyDown(key)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Input.GetKeyDown";
        public static string GetMenuPath() => "Input/If/GetKeyDown/(key)";
        public static string Signature() => " (key)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
