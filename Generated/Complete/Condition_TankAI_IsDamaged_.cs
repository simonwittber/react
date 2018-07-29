using DifferentMethods.React;
using UnityEngine;
using Complete;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of TankAI.IsDamaged on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_TankAI_IsDamaged_ : LeafNode
    {


        protected Complete.TankAI Component { get; set; }

        protected override NodeState Execute() {
            if(Component.IsDamaged()) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<Complete.TankAI>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK TankAI.IsDamaged";
        public static string GetMenuPath() => "TankAI/Condition/IsDamaged";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(Complete.TankAI);
    }
}
