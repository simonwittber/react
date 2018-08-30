using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    [System.Serializable]
    
    public class Function_Debug_Break_ : LeafNode
    {

        
        protected override NodeState Execute() {
            UnityEngine.Debug.Break();
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Debug.Break";
        public static string GetMenuPath() => "Debug/Function/Break";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Debug);
    }
}
