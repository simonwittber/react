using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Input_multiTouchEnabled_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Input.multiTouchEnabled) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Input.multiTouchEnabled";
        public static string GetMenuPath() => "Input/If/multiTouchEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }

    
    [System.Serializable]
    public class NotIf_Input_multiTouchEnabled_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(!UnityEngine.Input.multiTouchEnabled) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Input.multiTouchEnabled";
        public static string GetMenuPath() => "Input/If/multiTouchEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
