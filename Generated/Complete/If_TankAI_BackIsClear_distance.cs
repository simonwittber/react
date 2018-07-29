using DifferentMethods.React;
using UnityEngine;
using Complete;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of TankAI.BackIsClear on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_TankAI_BackIsClear_distance : DecoratorNode
    {
        public float distance;


        protected Complete.TankAI Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.BackIsClear(distance)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Complete.TankAI>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF TankAI.BackIsClear";
        public static string GetMenuPath() => "TankAI/If/BackIsClear";
        public static string Signature() => " (distance)";
        public override System.Type GetWrappedType() => typeof(Complete.TankAI);

    }
}
