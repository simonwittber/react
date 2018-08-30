using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Physics_Linecast_start_end_layerMask : LeafNode
    {
        public UnityEngine.Vector3 start;
        public UnityEngine.Vector3 end;
        public int layerMask;

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics.Linecast(start, end, layerMask))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Physics.Linecast";
        public static string GetMenuPath() => "Physics/Condition/Linecast/(start, end, layerMask)";
        public static string Signature() => " (start,end,layerMask)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }

    
    [System.Serializable]
    public class Not_Condition_Physics_Linecast_start_end_layerMask : LeafNode
    {
        public UnityEngine.Vector3 start;
        public UnityEngine.Vector3 end;
        public int layerMask;

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics.Linecast(start, end, layerMask))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Physics.Linecast";
        public static string GetMenuPath() => "Physics/Condition/Linecast/(start, end, layerMask)";
        public static string Signature() => " (start,end,layerMask)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
