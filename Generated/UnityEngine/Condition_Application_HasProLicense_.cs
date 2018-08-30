using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Application_HasProLicense_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Application.HasProLicense())
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Application.HasProLicense";
        public static string GetMenuPath() => "Application/Condition/HasProLicense";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }

    
    [System.Serializable]
    public class Not_Condition_Application_HasProLicense_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Application.HasProLicense())
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Application.HasProLicense";
        public static string GetMenuPath() => "Application/Condition/HasProLicense";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }
}
