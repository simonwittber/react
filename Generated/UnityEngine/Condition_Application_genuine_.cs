using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Application.genuine on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Application_genuine_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Application.genuine)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Application.genuine";
        public static string GetMenuPath() => "Application/Condition/genuine";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }
}
