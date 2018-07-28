using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Rigidbody2D.IsTouchingLayers on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Rigidbody2D_IsTouchingLayers_layerMask : LeafNode
    {
        public int layerMask;


        protected UnityEngine.Rigidbody2D Component { get; set; }

        protected override NodeState Execute() {
            if(Component.IsTouchingLayers(layerMask)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<UnityEngine.Rigidbody2D>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Rigidbody2D.IsTouchingLayers";
        public static string GetMenuPath() => "Rigidbody2D/Condition/IsTouchingLayers/(layerMask)";
        public static string Signature() => " (layerMask)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody2D);
    }
}
