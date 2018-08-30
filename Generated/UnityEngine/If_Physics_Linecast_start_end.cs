using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Physics_Linecast_start_end : DecoratorNode
    {
        public UnityEngine.Vector3 start;
        public UnityEngine.Vector3 end;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Physics.Linecast(start, end)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics.Linecast";
        public static string GetMenuPath() => "Physics/If/Linecast/(start, end)";
        public static string Signature() => " (start,end)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }

    
    [System.Serializable]
    public class NotIf_Physics_Linecast_start_end : DecoratorNode
    {
        public UnityEngine.Vector3 start;
        public UnityEngine.Vector3 end;

        
        protected override NodeState Execute() 
        {
            if(!UnityEngine.Physics.Linecast(start, end)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics.Linecast";
        public static string GetMenuPath() => "Physics/If/Linecast/(start, end)";
        public static string Signature() => " (start,end)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
