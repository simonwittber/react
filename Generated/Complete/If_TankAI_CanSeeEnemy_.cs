using DifferentMethods.React;
using UnityEngine;
using Complete;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of TankAI.CanSeeEnemy on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_TankAI_CanSeeEnemy_ : DecoratorNode
    {


        protected Complete.TankAI Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.CanSeeEnemy()) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Complete.TankAI>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF TankAI.CanSeeEnemy";
        public static string GetMenuPath() => "TankAI/If/CanSeeEnemy";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(Complete.TankAI);

    }
}
