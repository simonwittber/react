using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Physics.CheckSphere on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Physics_CheckSphere_position_radius : LeafNode
    {
        public UnityEngine.Vector3 position;
        public float radius;

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics.CheckSphere(position, radius))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Physics.CheckSphere";
        public static string GetMenuPath() => "Physics/Condition/CheckSphere/(position, radius)";
        public static string Signature() => " (position,radius)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
