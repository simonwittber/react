using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Physics_CapsuleCast_point1_point2_radius_direction_maxDistance : LeafNode
    {
        public UnityEngine.Vector3 point1;
        public UnityEngine.Vector3 point2;
        public float radius;
        public UnityEngine.Vector3 direction;
        public float maxDistance;

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics.CapsuleCast(point1, point2, radius, direction, maxDistance))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Physics.CapsuleCast";
        public static string GetMenuPath() => "Physics/Condition/CapsuleCast/(point1, point2, radius, direction, maxDistance)";
        public static string Signature() => " (point1,point2,radius,direction,maxDistance)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }

    
    [System.Serializable]
    public class Not_Condition_Physics_CapsuleCast_point1_point2_radius_direction_maxDistance : LeafNode
    {
        public UnityEngine.Vector3 point1;
        public UnityEngine.Vector3 point2;
        public float radius;
        public UnityEngine.Vector3 direction;
        public float maxDistance;

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics.CapsuleCast(point1, point2, radius, direction, maxDistance))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Physics.CapsuleCast";
        public static string GetMenuPath() => "Physics/Condition/CapsuleCast/(point1, point2, radius, direction, maxDistance)";
        public static string Signature() => " (point1,point2,radius,direction,maxDistance)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
