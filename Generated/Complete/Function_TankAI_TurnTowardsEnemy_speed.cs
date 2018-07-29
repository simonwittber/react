using DifferentMethods.React;
using UnityEngine;
using Complete;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call TankAI.TurnTowardsEnemy on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_TankAI_TurnTowardsEnemy_speed : LeafNode
    {
        public float speed;


        protected Complete.TankAI Component { get; set; }

        protected override NodeState Execute() {
            Component.TurnTowardsEnemy(speed);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Complete.TankAI>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "TankAI.TurnTowardsEnemy";
        public static string GetMenuPath() => "TankAI/Function/TurnTowardsEnemy";
        public static string Signature() => " (speed)";
        public override System.Type GetWrappedType() => typeof(Complete.TankAI);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(Complete.TankAI), typeof(Function_TankAI_TurnTowardsEnemy_speed));

    }
}
