using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Input.GetMouseButtonUp on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Input_GetMouseButtonUp_button : DecoratorNode
    {
        public int button;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Input.GetMouseButtonUp(button)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Input.GetMouseButtonUp";
        public static string GetMenuPath() => "Input/If/GetMouseButtonUp";
        public static string Signature() => " (button)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
