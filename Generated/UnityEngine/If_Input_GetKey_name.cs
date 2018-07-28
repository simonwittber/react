using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Input.GetKey on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Input_GetKey_name : DecoratorNode
    {
        public string id;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Input.GetKey(id)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Input.GetKey";
        public static string GetMenuPath() => "Input/If/GetKey/(name)";
        public static string Signature() => " (name)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
