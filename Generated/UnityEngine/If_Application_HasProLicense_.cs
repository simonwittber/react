using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Application.HasProLicense on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Application_HasProLicense_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Application.HasProLicense()) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Application.HasProLicense";
        public static string GetMenuPath() => "Application/If/HasProLicense";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }
}
