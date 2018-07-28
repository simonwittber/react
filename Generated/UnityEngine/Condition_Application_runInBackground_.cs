using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Application.runInBackground on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Application_runInBackground_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Application.runInBackground)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Application.runInBackground";
        public static string GetMenuPath() => "Application/Condition/runInBackground";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }
}
