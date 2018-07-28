using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Physics.Raycast on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Physics_Raycast_origin_direction_maxDistance_layerMask : DecoratorNode
    {
        public UnityEngine.Vector3 origin;
        public UnityEngine.Vector3 direction;
        public float maxDistance;
        public int layerMask;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Physics.Raycast(origin, direction, maxDistance, layerMask)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics.Raycast";
        public static string GetMenuPath() => "Physics/If/Raycast/(origin, direction, maxDistance, layerMask)";
        public static string Signature() => " (origin,direction,maxDistance,layerMask)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
