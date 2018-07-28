using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Application.HasUserAuthorization on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Application_HasUserAuthorization_mode : LeafNode
    {
        public UnityEngine.UserAuthorization mode;

        
        protected override NodeState Execute() {
            if(UnityEngine.Application.HasUserAuthorization(mode))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Application.HasUserAuthorization";
        public static string GetMenuPath() => "Application/Condition/HasUserAuthorization";
        public static string Signature() => " (mode)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }
}
