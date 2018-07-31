using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Application.isEditor on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Application_isEditor_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Application.isEditor)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Application.isEditor";
        public static string GetMenuPath() => "Application/Condition/isEditor";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }
}
