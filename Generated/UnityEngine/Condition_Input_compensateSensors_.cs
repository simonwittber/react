using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Input.compensateSensors on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Input_compensateSensors_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Input.compensateSensors)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Input.compensateSensors";
        public static string GetMenuPath() => "Input/Condition/compensateSensors";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
