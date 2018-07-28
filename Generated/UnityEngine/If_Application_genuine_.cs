using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Application.genuine on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Application_genuine_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Application.genuine) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Application.genuine";
        public static string GetMenuPath() => "Application/If/genuine";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }
}
