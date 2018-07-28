using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Physics.BoxCast on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Physics_BoxCast_center_halfExtents_direction : LeafNode
    {
        public UnityEngine.Vector3 center;
        public UnityEngine.Vector3 halfExtents;
        public UnityEngine.Vector3 direction;

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics.BoxCast(center, halfExtents, direction))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Physics.BoxCast";
        public static string GetMenuPath() => "Physics/Condition/BoxCast/(center, halfExtents, direction)";
        public static string Signature() => " (center,halfExtents,direction)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
