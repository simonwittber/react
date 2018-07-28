using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Physics2D.queriesHitTriggers on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Physics2D_queriesHitTriggers_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Physics2D.queriesHitTriggers) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics2D.queriesHitTriggers";
        public static string GetMenuPath() => "Physics2D/If/queriesHitTriggers";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics2D);
    }
}
