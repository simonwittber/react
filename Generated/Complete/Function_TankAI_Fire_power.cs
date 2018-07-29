using DifferentMethods.React;
using UnityEngine;
using Complete;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call TankAI.Fire on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_TankAI_Fire_power : LeafNode
    {
        public float power;


        protected Complete.TankAI Component { get; set; }

        protected override NodeState Execute() {
            Component.Fire(power);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Complete.TankAI>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "TankAI.Fire";
        public static string GetMenuPath() => "TankAI/Function/Fire";
        public static string Signature() => " (power)";
        public override System.Type GetWrappedType() => typeof(Complete.TankAI);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(Complete.TankAI), typeof(Function_TankAI_Fire_power));

    }
}
