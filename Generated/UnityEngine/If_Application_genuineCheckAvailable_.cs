using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Application.genuineCheckAvailable on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Application_genuineCheckAvailable_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Application.genuineCheckAvailable) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Application.genuineCheckAvailable";
        public static string GetMenuPath() => "Application/If/genuineCheckAvailable";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }
}
