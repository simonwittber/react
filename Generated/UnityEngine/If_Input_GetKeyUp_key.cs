using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Input.GetKeyUp on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Input_GetKeyUp_key : DecoratorNode
    {
        public UnityEngine.KeyCode key;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Input.GetKeyUp(key)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Input.GetKeyUp";
        public static string GetMenuPath() => "Input/If/GetKeyUp/(key)";
        public static string Signature() => " (key)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
