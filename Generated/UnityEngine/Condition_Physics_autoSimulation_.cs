using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Physics_autoSimulation_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics.autoSimulation)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Physics.autoSimulation";
        public static string GetMenuPath() => "Physics/Condition/autoSimulation";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }

    
    [System.Serializable]
    public class Not_Condition_Physics_autoSimulation_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics.autoSimulation)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Physics.autoSimulation";
        public static string GetMenuPath() => "Physics/Condition/autoSimulation";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
