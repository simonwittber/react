using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Input.multiTouchEnabled on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Input_multiTouchEnabled_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Input.multiTouchEnabled)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Input.multiTouchEnabled";
        public static string GetMenuPath() => "Input/Condition/multiTouchEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}