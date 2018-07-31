using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Collider2D.IsTouchingLayers on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Collider2D_IsTouchingLayers_layerMask : LeafNode
    {
        public int layerMask;

        protected UnityEngine.Collider2D Component { get; set; }

        protected override NodeState Execute() {
            if(Component.IsTouchingLayers(layerMask)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Collider2D>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Collider2D.IsTouchingLayers";
        public static string GetMenuPath() => "Collider2D/Condition/IsTouchingLayers/(layerMask)";
        public static string Signature() => " (layerMask)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Collider2D);
    }
}
