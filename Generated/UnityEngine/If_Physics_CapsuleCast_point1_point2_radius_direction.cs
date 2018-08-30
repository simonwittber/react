using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Physics_CapsuleCast_point1_point2_radius_direction : DecoratorNode
    {
        public UnityEngine.Vector3 point1;
        public UnityEngine.Vector3 point2;
        public float radius;
        public UnityEngine.Vector3 direction;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Physics.CapsuleCast(point1, point2, radius, direction)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics.CapsuleCast";
        public static string GetMenuPath() => "Physics/If/CapsuleCast/(point1, point2, radius, direction)";
        public static string Signature() => " (point1,point2,radius,direction)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }

    
    [System.Serializable]
    public class NotIf_Physics_CapsuleCast_point1_point2_radius_direction : DecoratorNode
    {
        public UnityEngine.Vector3 point1;
        public UnityEngine.Vector3 point2;
        public float radius;
        public UnityEngine.Vector3 direction;

        
        protected override NodeState Execute() 
        {
            if(!UnityEngine.Physics.CapsuleCast(point1, point2, radius, direction)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics.CapsuleCast";
        public static string GetMenuPath() => "Physics/If/CapsuleCast/(point1, point2, radius, direction)";
        public static string Signature() => " (point1,point2,radius,direction)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
