using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Physics_CheckSphere_position_radius_layerMask_queryTriggerInteraction : LeafNode
    {
        public UnityEngine.Vector3 position;
        public float radius;
        public int layerMask;
        public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics.CheckSphere(position, radius, layerMask, queryTriggerInteraction))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Physics.CheckSphere";
        public static string GetMenuPath() => "Physics/Condition/CheckSphere/(position, radius, layerMask, queryTriggerInteraction)";
        public static string Signature() => " (position,radius,layerMask,queryTriggerInteraction)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }

    
    [System.Serializable]
    public class Not_Condition_Physics_CheckSphere_position_radius_layerMask_queryTriggerInteraction : LeafNode
    {
        public UnityEngine.Vector3 position;
        public float radius;
        public int layerMask;
        public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics.CheckSphere(position, radius, layerMask, queryTriggerInteraction))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Physics.CheckSphere";
        public static string GetMenuPath() => "Physics/Condition/CheckSphere/(position, radius, layerMask, queryTriggerInteraction)";
        public static string Signature() => " (position,radius,layerMask,queryTriggerInteraction)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
