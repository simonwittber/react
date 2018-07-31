using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Input.touchSupported on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Input_touchSupported_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Input.touchSupported)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Input.touchSupported";
        public static string GetMenuPath() => "Input/Condition/touchSupported";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
