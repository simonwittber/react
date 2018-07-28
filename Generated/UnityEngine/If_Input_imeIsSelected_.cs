using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Input.imeIsSelected on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Input_imeIsSelected_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Input.imeIsSelected) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Input.imeIsSelected";
        public static string GetMenuPath() => "Input/If/imeIsSelected";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
