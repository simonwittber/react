using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Input_GetKey_key : DecoratorNode
    {
        public UnityEngine.KeyCode key;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Input.GetKey(key)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Input.GetKey";
        public static string GetMenuPath() => "Input/If/GetKey/(key)";
        public static string Signature() => " (key)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }

    
    [System.Serializable]
    public class NotIf_Input_GetKey_key : DecoratorNode
    {
        public UnityEngine.KeyCode key;

        
        protected override NodeState Execute() 
        {
            if(!UnityEngine.Input.GetKey(key)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Input.GetKey";
        public static string GetMenuPath() => "Input/If/GetKey/(key)";
        public static string Signature() => " (key)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
