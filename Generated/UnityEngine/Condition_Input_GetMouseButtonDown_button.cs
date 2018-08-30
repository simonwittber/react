using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Input_GetMouseButtonDown_button : LeafNode
    {
        public int button;

        
        protected override NodeState Execute() {
            if(UnityEngine.Input.GetMouseButtonDown(button))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Input.GetMouseButtonDown";
        public static string GetMenuPath() => "Input/Condition/GetMouseButtonDown";
        public static string Signature() => " (button)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }

    
    [System.Serializable]
    public class Not_Condition_Input_GetMouseButtonDown_button : LeafNode
    {
        public int button;

        
        protected override NodeState Execute() {
            if(UnityEngine.Input.GetMouseButtonDown(button))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Input.GetMouseButtonDown";
        public static string GetMenuPath() => "Input/Condition/GetMouseButtonDown";
        public static string Signature() => " (button)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
