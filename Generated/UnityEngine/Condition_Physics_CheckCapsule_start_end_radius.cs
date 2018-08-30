using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Physics_CheckCapsule_start_end_radius : LeafNode
    {
        public UnityEngine.Vector3 start;
        public UnityEngine.Vector3 end;
        public float radius;

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics.CheckCapsule(start, end, radius))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Physics.CheckCapsule";
        public static string GetMenuPath() => "Physics/Condition/CheckCapsule/(start, end, radius)";
        public static string Signature() => " (start,end,radius)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }

    
    [System.Serializable]
    public class Not_Condition_Physics_CheckCapsule_start_end_radius : LeafNode
    {
        public UnityEngine.Vector3 start;
        public UnityEngine.Vector3 end;
        public float radius;

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics.CheckCapsule(start, end, radius))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Physics.CheckCapsule";
        public static string GetMenuPath() => "Physics/Condition/CheckCapsule/(start, end, radius)";
        public static string Signature() => " (start,end,radius)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
