using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Physics_CheckSphere_position_radius_layerMask : DecoratorNode
    {
        public UnityEngine.Vector3 position;
        public float radius;
        public int layerMask;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Physics.CheckSphere(position, radius, layerMask)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics.CheckSphere";
        public static string GetMenuPath() => "Physics/If/CheckSphere/(position, radius, layerMask)";
        public static string Signature() => " (position,radius,layerMask)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }

    
    [System.Serializable]
    public class NotIf_Physics_CheckSphere_position_radius_layerMask : DecoratorNode
    {
        public UnityEngine.Vector3 position;
        public float radius;
        public int layerMask;

        
        protected override NodeState Execute() 
        {
            if(!UnityEngine.Physics.CheckSphere(position, radius, layerMask)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics.CheckSphere";
        public static string GetMenuPath() => "Physics/If/CheckSphere/(position, radius, layerMask)";
        public static string Signature() => " (position,radius,layerMask)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
