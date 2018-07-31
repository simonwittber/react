using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of Physics.queriesHitBackfaces on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Physics_queriesHitBackfaces_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Physics.queriesHitBackfaces) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics.queriesHitBackfaces";
        public static string GetMenuPath() => "Physics/If/queriesHitBackfaces";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
