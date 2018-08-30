using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Physics2D_autoSimulation_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics2D.autoSimulation)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Physics2D.autoSimulation";
        public static string GetMenuPath() => "Physics2D/Condition/autoSimulation";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics2D);
    }

    
    [System.Serializable]
    public class Not_Condition_Physics2D_autoSimulation_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics2D.autoSimulation)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Physics2D.autoSimulation";
        public static string GetMenuPath() => "Physics2D/Condition/autoSimulation";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics2D);
    }
}
