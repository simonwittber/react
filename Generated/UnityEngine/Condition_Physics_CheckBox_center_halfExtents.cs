using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Physics.CheckBox on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Physics_CheckBox_center_halfExtents : LeafNode
    {
        public UnityEngine.Vector3 center;
        public UnityEngine.Vector3 halfExtents;

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics.CheckBox(center, halfExtents))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Physics.CheckBox";
        public static string GetMenuPath() => "Physics/Condition/CheckBox/(center, halfExtents)";
        public static string Signature() => " (center,halfExtents)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
