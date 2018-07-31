using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes method call Application.Quit on the class, then returns a NoResult state.
    /// </summary>
    [System.Serializable]
    
    public class Function_Application_Quit_ : LeafNode
    {

        
        protected override NodeState Execute() {
            UnityEngine.Application.Quit();
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Application.Quit";
        public static string GetMenuPath() => "Application/Function/Quit";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }
}
