using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Input.anyKeyDown on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Input_anyKeyDown_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Input.anyKeyDown)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Input.anyKeyDown";
        public static string GetMenuPath() => "Input/Condition/anyKeyDown";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
