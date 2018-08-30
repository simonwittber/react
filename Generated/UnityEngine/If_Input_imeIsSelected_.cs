using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Input_imeIsSelected_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Input.imeIsSelected) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Input.imeIsSelected";
        public static string GetMenuPath() => "Input/If/imeIsSelected";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }

    
    [System.Serializable]
    public class NotIf_Input_imeIsSelected_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(!UnityEngine.Input.imeIsSelected) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Input.imeIsSelected";
        public static string GetMenuPath() => "Input/If/imeIsSelected";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
