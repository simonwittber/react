using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Input_GetKeyUp_key : LeafNode
    {
        public UnityEngine.KeyCode key;

        
        protected override NodeState Execute() {
            if(UnityEngine.Input.GetKeyUp(key))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Input.GetKeyUp";
        public static string GetMenuPath() => "Input/Condition/GetKeyUp/(key)";
        public static string Signature() => " (key)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }

    
    [System.Serializable]
    public class Not_Condition_Input_GetKeyUp_key : LeafNode
    {
        public UnityEngine.KeyCode key;

        
        protected override NodeState Execute() {
            if(UnityEngine.Input.GetKeyUp(key))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Input.GetKeyUp";
        public static string GetMenuPath() => "Input/Condition/GetKeyUp/(key)";
        public static string Signature() => " (key)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
