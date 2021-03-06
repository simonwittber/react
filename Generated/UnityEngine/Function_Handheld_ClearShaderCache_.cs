using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    [System.Serializable]
    
    public class Function_Handheld_ClearShaderCache_ : LeafNode
    {

        
        protected override NodeState Execute() {
            UnityEngine.Handheld.ClearShaderCache();
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Handheld.ClearShaderCache";
        public static string GetMenuPath() => "Handheld/Function/ClearShaderCache";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Handheld);
    }
}
