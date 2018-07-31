using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Physics2D.queriesHitTriggers on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Physics2D_queriesHitTriggers_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics2D.queriesHitTriggers)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Physics2D.queriesHitTriggers";
        public static string GetMenuPath() => "Physics2D/Condition/queriesHitTriggers";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics2D);
    }
}
