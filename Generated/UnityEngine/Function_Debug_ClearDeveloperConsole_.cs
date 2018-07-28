using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes method call Debug.ClearDeveloperConsole on the class, then returns a NoResult state.
    /// </summary>
    [System.Serializable]
    
    public class Function_Debug_ClearDeveloperConsole_ : LeafNode
    {

        
        protected override NodeState Execute() {
            UnityEngine.Debug.ClearDeveloperConsole();
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Debug.ClearDeveloperConsole";
        public static string GetMenuPath() => "Debug/Function/ClearDeveloperConsole";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Debug);
    }
}
