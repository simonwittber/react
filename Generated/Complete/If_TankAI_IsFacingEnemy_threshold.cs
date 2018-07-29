using DifferentMethods.React;
using UnityEngine;
using Complete;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of TankAI.IsFacingEnemy on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_TankAI_IsFacingEnemy_threshold : DecoratorNode
    {
        public float threshold;


        protected Complete.TankAI Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.IsFacingEnemy(threshold)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Complete.TankAI>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF TankAI.IsFacingEnemy";
        public static string GetMenuPath() => "TankAI/If/IsFacingEnemy";
        public static string Signature() => " (threshold)";
        public override System.Type GetWrappedType() => typeof(Complete.TankAI);

    }
}
