using DifferentMethods.React;
using UnityEngine;
using Complete;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of TankAI.IsDamaged on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_TankAI_IsDamaged_ : DecoratorNode
    {


        protected Complete.TankAI Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.IsDamaged()) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Complete.TankAI>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF TankAI.IsDamaged";
        public static string GetMenuPath() => "TankAI/If/IsDamaged";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(Complete.TankAI);

    }
}
