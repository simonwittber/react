using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Physics.queriesHitTriggers on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Physics_queriesHitTriggers_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Physics.queriesHitTriggers) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics.queriesHitTriggers";
        public static string GetMenuPath() => "Physics/If/queriesHitTriggers";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
