using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of Rigidbody2D.IsTouchingLayers on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Rigidbody2D_IsTouchingLayers_layerMask : DecoratorNode
    {
        public int layerMask;

        protected UnityEngine.Rigidbody2D Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.IsTouchingLayers(layerMask)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Rigidbody2D>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Rigidbody2D.IsTouchingLayers";
        public static string GetMenuPath() => "Rigidbody2D/If/IsTouchingLayers/(layerMask)";
        public static string Signature() => " (layerMask)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody2D);
    }
}
