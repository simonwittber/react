using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Physics2D.showColliderSleep on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Physics2D_showColliderSleep_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Physics2D.showColliderSleep) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics2D.showColliderSleep";
        public static string GetMenuPath() => "Physics2D/If/showColliderSleep";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics2D);
    }
}
