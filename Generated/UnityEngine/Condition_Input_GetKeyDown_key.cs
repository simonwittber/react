using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Input_GetKeyDown_key : LeafNode
    {
        public UnityEngine.KeyCode key;

        
        protected override NodeState Execute() {
            if(UnityEngine.Input.GetKeyDown(key))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Input.GetKeyDown";
        public static string GetMenuPath() => "Input/Condition/GetKeyDown/(key)";
        public static string Signature() => " (key)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }

    
    [System.Serializable]
    public class Not_Condition_Input_GetKeyDown_key : LeafNode
    {
        public UnityEngine.KeyCode key;

        
        protected override NodeState Execute() {
            if(UnityEngine.Input.GetKeyDown(key))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Input.GetKeyDown";
        public static string GetMenuPath() => "Input/Condition/GetKeyDown/(key)";
        public static string Signature() => " (key)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
