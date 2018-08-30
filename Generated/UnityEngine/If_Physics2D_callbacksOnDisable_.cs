using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Physics2D_callbacksOnDisable_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Physics2D.callbacksOnDisable) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics2D.callbacksOnDisable";
        public static string GetMenuPath() => "Physics2D/If/callbacksOnDisable";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics2D);
    }

    
    [System.Serializable]
    public class NotIf_Physics2D_callbacksOnDisable_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(!UnityEngine.Physics2D.callbacksOnDisable) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics2D.callbacksOnDisable";
        public static string GetMenuPath() => "Physics2D/If/callbacksOnDisable";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics2D);
    }
}
