using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes method call Handheld.SetActivityIndicatorStyle on the class, then returns a NoResult state.
    /// </summary>
    [System.Serializable]
    
    public class Function_Handheld_SetActivityIndicatorStyle_style : LeafNode
    {
        public UnityEngine.AndroidActivityIndicatorStyle style;

        
        protected override NodeState Execute() {
            UnityEngine.Handheld.SetActivityIndicatorStyle(style);
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Handheld.SetActivityIndicatorStyle";
        public static string GetMenuPath() => "Handheld/Function/SetActivityIndicatorStyle/(style)";
        public static string Signature() => " (style)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Handheld);
    }
}
