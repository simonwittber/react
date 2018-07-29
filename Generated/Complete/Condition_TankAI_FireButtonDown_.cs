using DifferentMethods.React;
using UnityEngine;
using Complete;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of TankAI.FireButtonDown on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_TankAI_FireButtonDown_ : LeafNode
    {


        protected Complete.TankAI Component { get; set; }

        protected override NodeState Execute() {
            if(Component.FireButtonDown) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<Complete.TankAI>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK TankAI.FireButtonDown";
        public static string GetMenuPath() => "TankAI/Condition/FireButtonDown";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(Complete.TankAI);
    }
}
