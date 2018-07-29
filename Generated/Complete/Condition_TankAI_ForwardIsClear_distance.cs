using DifferentMethods.React;
using UnityEngine;
using Complete;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of TankAI.ForwardIsClear on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_TankAI_ForwardIsClear_distance : LeafNode
    {
        public float distance;


        protected Complete.TankAI Component { get; set; }

        protected override NodeState Execute() {
            if(Component.ForwardIsClear(distance)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<Complete.TankAI>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK TankAI.ForwardIsClear";
        public static string GetMenuPath() => "TankAI/Condition/ForwardIsClear";
        public static string Signature() => " (distance)";
        public override System.Type GetWrappedType() => typeof(Complete.TankAI);
    }
}
