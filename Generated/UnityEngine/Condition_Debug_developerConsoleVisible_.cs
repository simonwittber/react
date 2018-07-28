using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Debug.developerConsoleVisible on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Debug_developerConsoleVisible_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Debug.developerConsoleVisible)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Debug.developerConsoleVisible";
        public static string GetMenuPath() => "Debug/Condition/developerConsoleVisible";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Debug);
    }
}
