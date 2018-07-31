using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes method call Handheld.StartActivityIndicator on the class, then returns a NoResult state.
    /// </summary>
    [System.Serializable]
    
    public class Function_Handheld_StartActivityIndicator_ : LeafNode
    {

        
        protected override NodeState Execute() {
            UnityEngine.Handheld.StartActivityIndicator();
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Handheld.StartActivityIndicator";
        public static string GetMenuPath() => "Handheld/Function/StartActivityIndicator";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Handheld);
    }
}
