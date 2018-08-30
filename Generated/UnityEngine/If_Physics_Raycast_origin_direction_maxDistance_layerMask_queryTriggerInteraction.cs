using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Physics_Raycast_origin_direction_maxDistance_layerMask_queryTriggerInteraction : DecoratorNode
    {
        public UnityEngine.Vector3 origin;
        public UnityEngine.Vector3 direction;
        public float maxDistance;
        public int layerMask;
        public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Physics.Raycast(origin, direction, maxDistance, layerMask, queryTriggerInteraction)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics.Raycast";
        public static string GetMenuPath() => "Physics/If/Raycast/(origin, direction, maxDistance, layerMask, queryTriggerInteraction)";
        public static string Signature() => " (origin,direction,maxDistance,layerMask,queryTriggerInteraction)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }

    
    [System.Serializable]
    public class NotIf_Physics_Raycast_origin_direction_maxDistance_layerMask_queryTriggerInteraction : DecoratorNode
    {
        public UnityEngine.Vector3 origin;
        public UnityEngine.Vector3 direction;
        public float maxDistance;
        public int layerMask;
        public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;

        
        protected override NodeState Execute() 
        {
            if(!UnityEngine.Physics.Raycast(origin, direction, maxDistance, layerMask, queryTriggerInteraction)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics.Raycast";
        public static string GetMenuPath() => "Physics/If/Raycast/(origin, direction, maxDistance, layerMask, queryTriggerInteraction)";
        public static string Signature() => " (origin,direction,maxDistance,layerMask,queryTriggerInteraction)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
