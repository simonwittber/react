using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Physics_CheckCapsule_start_end_radius : DecoratorNode
    {
        public UnityEngine.Vector3 start;
        public UnityEngine.Vector3 end;
        public float radius;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Physics.CheckCapsule(start, end, radius)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics.CheckCapsule";
        public static string GetMenuPath() => "Physics/If/CheckCapsule/(start, end, radius)";
        public static string Signature() => " (start,end,radius)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }

    
    [System.Serializable]
    public class NotIf_Physics_CheckCapsule_start_end_radius : DecoratorNode
    {
        public UnityEngine.Vector3 start;
        public UnityEngine.Vector3 end;
        public float radius;

        
        protected override NodeState Execute() 
        {
            if(!UnityEngine.Physics.CheckCapsule(start, end, radius)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics.CheckCapsule";
        public static string GetMenuPath() => "Physics/If/CheckCapsule/(start, end, radius)";
        public static string Signature() => " (start,end,radius)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
