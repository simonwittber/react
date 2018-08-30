using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Input_GetButtonUp_buttonName : LeafNode
    {
        public string buttonName;

        
        protected override NodeState Execute() {
            if(UnityEngine.Input.GetButtonUp(buttonName))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Input.GetButtonUp";
        public static string GetMenuPath() => "Input/Condition/GetButtonUp";
        public static string Signature() => " (buttonName)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }

    
    [System.Serializable]
    public class Not_Condition_Input_GetButtonUp_buttonName : LeafNode
    {
        public string buttonName;

        
        protected override NodeState Execute() {
            if(UnityEngine.Input.GetButtonUp(buttonName))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Input.GetButtonUp";
        public static string GetMenuPath() => "Input/Condition/GetButtonUp";
        public static string Signature() => " (buttonName)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
