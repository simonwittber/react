using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Physics_Raycast_origin_direction : DecoratorNode
    {
        public UnityEngine.Vector3 origin;
        public UnityEngine.Vector3 direction;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Physics.Raycast(origin, direction)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics.Raycast";
        public static string GetMenuPath() => "Physics/If/Raycast/(origin, direction)";
        public static string Signature() => " (origin,direction)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }

    
    [System.Serializable]
    public class NotIf_Physics_Raycast_origin_direction : DecoratorNode
    {
        public UnityEngine.Vector3 origin;
        public UnityEngine.Vector3 direction;

        
        protected override NodeState Execute() 
        {
            if(!UnityEngine.Physics.Raycast(origin, direction)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics.Raycast";
        public static string GetMenuPath() => "Physics/If/Raycast/(origin, direction)";
        public static string Signature() => " (origin,direction)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
