using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of Collider2D.IsTouchingLayers on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Collider2D_IsTouchingLayers_layerMask : DecoratorNode
    {
        public int layerMask;

        protected UnityEngine.Collider2D Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.IsTouchingLayers(layerMask)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Collider2D>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Collider2D.IsTouchingLayers";
        public static string GetMenuPath() => "Collider2D/If/IsTouchingLayers/(layerMask)";
        public static string Signature() => " (layerMask)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Collider2D);
    }
}
