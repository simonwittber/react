using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    [System.Serializable]
    
    public class Function_Debug_ClearDeveloperConsole_ : LeafNode
    {

        
        protected override NodeState Execute() {
            UnityEngine.Debug.ClearDeveloperConsole();
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Debug.ClearDeveloperConsole";
        public static string GetMenuPath() => "Debug/Function/ClearDeveloperConsole";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Debug);
    }
}
