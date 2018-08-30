using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Application_isFocused_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Application.isFocused)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Application.isFocused";
        public static string GetMenuPath() => "Application/Condition/isFocused";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }

    
    [System.Serializable]
    public class Not_Condition_Application_isFocused_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Application.isFocused)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Application.isFocused";
        public static string GetMenuPath() => "Application/Condition/isFocused";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }
}
