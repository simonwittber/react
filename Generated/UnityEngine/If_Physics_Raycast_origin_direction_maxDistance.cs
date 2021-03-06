using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Physics_Raycast_origin_direction_maxDistance : DecoratorNode
    {
        public UnityEngine.Vector3 origin;
        public UnityEngine.Vector3 direction;
        public float maxDistance;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Physics.Raycast(origin, direction, maxDistance)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics.Raycast";
        public static string GetMenuPath() => "Physics/If/Raycast/(origin, direction, maxDistance)";
        public static string Signature() => " (origin,direction,maxDistance)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }

    
    [System.Serializable]
    public class NotIf_Physics_Raycast_origin_direction_maxDistance : DecoratorNode
    {
        public UnityEngine.Vector3 origin;
        public UnityEngine.Vector3 direction;
        public float maxDistance;

        
        protected override NodeState Execute() 
        {
            if(!UnityEngine.Physics.Raycast(origin, direction, maxDistance)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics.Raycast";
        public static string GetMenuPath() => "Physics/If/Raycast/(origin, direction, maxDistance)";
        public static string Signature() => " (origin,direction,maxDistance)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
