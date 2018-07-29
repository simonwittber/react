using DifferentMethods.React;
using UnityEngine;
using Complete;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of TankAI.FireButtonDown on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_TankAI_FireButtonDown_ : DecoratorNode
    {


        protected Complete.TankAI Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.FireButtonDown) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Complete.TankAI>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF TankAI.FireButtonDown";
        public static string GetMenuPath() => "TankAI/If/FireButtonDown";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(Complete.TankAI);

    }
}
