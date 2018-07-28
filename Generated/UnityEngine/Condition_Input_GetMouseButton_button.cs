using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Input.GetMouseButton on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Input_GetMouseButton_button : LeafNode
    {
        public int button;

        
        protected override NodeState Execute() {
            if(UnityEngine.Input.GetMouseButton(button))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Input.GetMouseButton";
        public static string GetMenuPath() => "Input/Condition/GetMouseButton";
        public static string Signature() => " (button)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
