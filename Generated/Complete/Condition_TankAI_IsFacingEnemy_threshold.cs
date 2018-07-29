using DifferentMethods.React;
using UnityEngine;
using Complete;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of TankAI.IsFacingEnemy on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_TankAI_IsFacingEnemy_threshold : LeafNode
    {
        public float threshold;


        protected Complete.TankAI Component { get; set; }

        protected override NodeState Execute() {
            if(Component.IsFacingEnemy(threshold)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<Complete.TankAI>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK TankAI.IsFacingEnemy";
        public static string GetMenuPath() => "TankAI/Condition/IsFacingEnemy";
        public static string Signature() => " (threshold)";
        public override System.Type GetWrappedType() => typeof(Complete.TankAI);
    }
}
