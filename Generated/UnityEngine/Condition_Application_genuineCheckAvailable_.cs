using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Application.genuineCheckAvailable on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Application_genuineCheckAvailable_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Application.genuineCheckAvailable)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Application.genuineCheckAvailable";
        public static string GetMenuPath() => "Application/Condition/genuineCheckAvailable";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }
}
