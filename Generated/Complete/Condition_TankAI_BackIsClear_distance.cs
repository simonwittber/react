using DifferentMethods.React;
using UnityEngine;
using Complete;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of TankAI.BackIsClear on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_TankAI_BackIsClear_distance : LeafNode
    {
        public float distance;


        protected Complete.TankAI Component { get; set; }

        protected override NodeState Execute() {
            if(Component.BackIsClear(distance)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<Complete.TankAI>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK TankAI.BackIsClear";
        public static string GetMenuPath() => "TankAI/Condition/BackIsClear";
        public static string Signature() => " (distance)";
        public override System.Type GetWrappedType() => typeof(Complete.TankAI);
    }
}
