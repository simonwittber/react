using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Physics.CapsuleCast on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Physics_CapsuleCast_point1_point2_radius_direction_maxDistance : DecoratorNode
    {
        public UnityEngine.Vector3 point1;
        public UnityEngine.Vector3 point2;
        public float radius;
        public UnityEngine.Vector3 direction;
        public float maxDistance;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Physics.CapsuleCast(point1, point2, radius, direction, maxDistance)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics.CapsuleCast";
        public static string GetMenuPath() => "Physics/If/CapsuleCast/(point1, point2, radius, direction, maxDistance)";
        public static string Signature() => " (point1,point2,radius,direction,maxDistance)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}