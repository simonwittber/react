using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    [System.Serializable]
    
    public class Function_Handheld_StopActivityIndicator_ : LeafNode
    {

        
        protected override NodeState Execute() {
            UnityEngine.Handheld.StopActivityIndicator();
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Handheld.StopActivityIndicator";
        public static string GetMenuPath() => "Handheld/Function/StopActivityIndicator";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Handheld);
    }
}
