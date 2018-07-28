using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Input.anyKey on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Input_anyKey_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Input.anyKey)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Input.anyKey";
        public static string GetMenuPath() => "Input/Condition/anyKey";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
