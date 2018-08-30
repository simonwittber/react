using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Physics_BoxCast_center_halfExtents_direction : DecoratorNode
    {
        public UnityEngine.Vector3 center;
        public UnityEngine.Vector3 halfExtents;
        public UnityEngine.Vector3 direction;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Physics.BoxCast(center, halfExtents, direction)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics.BoxCast";
        public static string GetMenuPath() => "Physics/If/BoxCast/(center, halfExtents, direction)";
        public static string Signature() => " (center,halfExtents,direction)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }

    
    [System.Serializable]
    public class NotIf_Physics_BoxCast_center_halfExtents_direction : DecoratorNode
    {
        public UnityEngine.Vector3 center;
        public UnityEngine.Vector3 halfExtents;
        public UnityEngine.Vector3 direction;

        
        protected override NodeState Execute() 
        {
            if(!UnityEngine.Physics.BoxCast(center, halfExtents, direction)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics.BoxCast";
        public static string GetMenuPath() => "Physics/If/BoxCast/(center, halfExtents, direction)";
        public static string Signature() => " (center,halfExtents,direction)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
