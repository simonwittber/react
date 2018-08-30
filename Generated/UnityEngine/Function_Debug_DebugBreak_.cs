using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    [System.Serializable]
    
    public class Function_Debug_DebugBreak_ : LeafNode
    {

        
        protected override NodeState Execute() {
            UnityEngine.Debug.DebugBreak();
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Debug.DebugBreak";
        public static string GetMenuPath() => "Debug/Function/DebugBreak";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Debug);
    }
}
