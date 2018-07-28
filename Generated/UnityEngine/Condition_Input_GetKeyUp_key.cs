using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Input.GetKeyUp on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Input_GetKeyUp_key : LeafNode
    {
        public UnityEngine.KeyCode key;

        
        protected override NodeState Execute() {
            if(UnityEngine.Input.GetKeyUp(key))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Input.GetKeyUp";
        public static string GetMenuPath() => "Input/Condition/GetKeyUp/(key)";
        public static string Signature() => " (key)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
