using DifferentMethods.React;
using UnityEngine;
using Complete;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of TankAI.CanSeeEnemy on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_TankAI_CanSeeEnemy_ : LeafNode
    {


        protected Complete.TankAI Component { get; set; }

        protected override NodeState Execute() {
            if(Component.CanSeeEnemy()) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<Complete.TankAI>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK TankAI.CanSeeEnemy";
        public static string GetMenuPath() => "TankAI/Condition/CanSeeEnemy";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(Complete.TankAI);
    }
}
