using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Physics.Raycast on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Physics_Raycast_origin_direction_maxDistance_layerMask_queryTriggerInteraction : LeafNode
    {
        public UnityEngine.Vector3 origin;
        public UnityEngine.Vector3 direction;
        public float maxDistance;
        public int layerMask;
        public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics.Raycast(origin, direction, maxDistance, layerMask, queryTriggerInteraction))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Physics.Raycast";
        public static string GetMenuPath() => "Physics/Condition/Raycast/(origin, direction, maxDistance, layerMask, queryTriggerInteraction)";
        public static string Signature() => " (origin,direction,maxDistance,layerMask,queryTriggerInteraction)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
