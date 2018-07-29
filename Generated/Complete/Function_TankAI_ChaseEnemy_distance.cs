using DifferentMethods.React;
using UnityEngine;
using Complete;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call TankAI.ChaseEnemy on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_TankAI_ChaseEnemy_distance : LeafNode
    {
        public float distance;


        protected Complete.TankAI Component { get; set; }

        protected override NodeState Execute() {
            Component.ChaseEnemy(distance);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Complete.TankAI>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "TankAI.ChaseEnemy";
        public static string GetMenuPath() => "TankAI/Function/ChaseEnemy";
        public static string Signature() => " (distance)";
        public override System.Type GetWrappedType() => typeof(Complete.TankAI);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(Complete.TankAI), typeof(Function_TankAI_ChaseEnemy_distance));

    }
}
