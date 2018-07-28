using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Physics.Linecast on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Physics_Linecast_start_end : LeafNode
    {
        public UnityEngine.Vector3 start;
        public UnityEngine.Vector3 end;

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics.Linecast(start, end))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Physics.Linecast";
        public static string GetMenuPath() => "Physics/Condition/Linecast/(start, end)";
        public static string Signature() => " (start,end)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
