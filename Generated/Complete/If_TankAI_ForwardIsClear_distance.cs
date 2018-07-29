using DifferentMethods.React;
using UnityEngine;
using Complete;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of TankAI.ForwardIsClear on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_TankAI_ForwardIsClear_distance : DecoratorNode
    {
        public float distance;


        protected Complete.TankAI Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.ForwardIsClear(distance)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Complete.TankAI>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF TankAI.ForwardIsClear";
        public static string GetMenuPath() => "TankAI/If/ForwardIsClear";
        public static string Signature() => " (distance)";
        public override System.Type GetWrappedType() => typeof(Complete.TankAI);

    }
}
