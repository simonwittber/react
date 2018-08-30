using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
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

    
    [System.Serializable]
    public class Not_Condition_Input_compensateSensors_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Input.compensateSensors)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Input.compensateSensors";
        public static string GetMenuPath() => "Input/Condition/compensateSensors";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
