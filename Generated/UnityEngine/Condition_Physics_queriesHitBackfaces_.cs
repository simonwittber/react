using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Physics_queriesHitBackfaces_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics.queriesHitBackfaces)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Physics.queriesHitBackfaces";
        public static string GetMenuPath() => "Physics/Condition/queriesHitBackfaces";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }

    
    [System.Serializable]
    public class Not_Condition_Physics_queriesHitBackfaces_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics.queriesHitBackfaces)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Physics.queriesHitBackfaces";
        public static string GetMenuPath() => "Physics/Condition/queriesHitBackfaces";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
