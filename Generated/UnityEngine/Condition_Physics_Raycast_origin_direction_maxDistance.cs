using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Physics_Raycast_origin_direction_maxDistance : LeafNode
    {
        public UnityEngine.Vector3 origin;
        public UnityEngine.Vector3 direction;
        public float maxDistance;

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics.Raycast(origin, direction, maxDistance))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Physics.Raycast";
        public static string GetMenuPath() => "Physics/Condition/Raycast/(origin, direction, maxDistance)";
        public static string Signature() => " (origin,direction,maxDistance)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }

    
    [System.Serializable]
    public class Not_Condition_Physics_Raycast_origin_direction_maxDistance : LeafNode
    {
        public UnityEngine.Vector3 origin;
        public UnityEngine.Vector3 direction;
        public float maxDistance;

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics.Raycast(origin, direction, maxDistance))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Physics.Raycast";
        public static string GetMenuPath() => "Physics/Condition/Raycast/(origin, direction, maxDistance)";
        public static string Signature() => " (origin,direction,maxDistance)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
