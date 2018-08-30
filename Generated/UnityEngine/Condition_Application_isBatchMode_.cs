using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Application_isBatchMode_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Application.isBatchMode)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Application.isBatchMode";
        public static string GetMenuPath() => "Application/Condition/isBatchMode";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }

    
    [System.Serializable]
    public class Not_Condition_Application_isBatchMode_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Application.isBatchMode)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Application.isBatchMode";
        public static string GetMenuPath() => "Application/Condition/isBatchMode";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }
}
