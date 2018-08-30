using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Application_genuineCheckAvailable_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Application.genuineCheckAvailable)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Application.genuineCheckAvailable";
        public static string GetMenuPath() => "Application/Condition/genuineCheckAvailable";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }

    
    [System.Serializable]
    public class Not_Condition_Application_genuineCheckAvailable_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Application.genuineCheckAvailable)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Application.genuineCheckAvailable";
        public static string GetMenuPath() => "Application/Condition/genuineCheckAvailable";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }
}
