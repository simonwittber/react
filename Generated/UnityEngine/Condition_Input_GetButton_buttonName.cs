using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Input_GetButton_buttonName : LeafNode
    {
        public string buttonName;

        
        protected override NodeState Execute() {
            if(UnityEngine.Input.GetButton(buttonName))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Input.GetButton";
        public static string GetMenuPath() => "Input/Condition/GetButton";
        public static string Signature() => " (buttonName)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }

    
    [System.Serializable]
    public class Not_Condition_Input_GetButton_buttonName : LeafNode
    {
        public string buttonName;

        
        protected override NodeState Execute() {
            if(UnityEngine.Input.GetButton(buttonName))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Input.GetButton";
        public static string GetMenuPath() => "Input/Condition/GetButton";
        public static string Signature() => " (buttonName)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
