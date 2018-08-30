using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    [System.Serializable]
    
    public class Function_Handheld_Vibrate_ : LeafNode
    {

        
        protected override NodeState Execute() {
            UnityEngine.Handheld.Vibrate();
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Handheld.Vibrate";
        public static string GetMenuPath() => "Handheld/Function/Vibrate";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Handheld);
    }
}
