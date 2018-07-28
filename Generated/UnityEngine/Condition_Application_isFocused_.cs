using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Application.isFocused on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Application_isFocused_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Application.isFocused)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Application.isFocused";
        public static string GetMenuPath() => "Application/Condition/isFocused";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }
}
