using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Physics2D.IsTouchingLayers on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Physics2D_IsTouchingLayers_collider_layerMask : LeafNode
    {
        public UnityEngine.Collider2D collider;
        public int layerMask;

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics2D.IsTouchingLayers(collider, layerMask))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Physics2D.IsTouchingLayers";
        public static string GetMenuPath() => "Physics2D/Condition/IsTouchingLayers/(collider, layerMask)";
        public static string Signature() => " (collider,layerMask)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics2D);
    }
}
