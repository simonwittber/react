using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of Physics2D.queriesStartInColliders on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Physics2D_queriesStartInColliders_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Physics2D.queriesStartInColliders) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics2D.queriesStartInColliders";
        public static string GetMenuPath() => "Physics2D/If/queriesStartInColliders";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics2D);
    }
}
