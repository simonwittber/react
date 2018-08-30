using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Debug_isDebugBuild_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Debug.isDebugBuild)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Debug.isDebugBuild";
        public static string GetMenuPath() => "Debug/Condition/isDebugBuild";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Debug);
    }

    
    [System.Serializable]
    public class Not_Condition_Debug_isDebugBuild_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Debug.isDebugBuild)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Debug.isDebugBuild";
        public static string GetMenuPath() => "Debug/Condition/isDebugBuild";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Debug);
    }
}
