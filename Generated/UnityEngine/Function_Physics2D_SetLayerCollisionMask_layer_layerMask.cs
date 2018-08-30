using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    [System.Serializable]
    
    public class Function_Physics2D_SetLayerCollisionMask_layer_layerMask : LeafNode
    {
        public int layer;
        public int layerMask;

        
        protected override NodeState Execute() {
            UnityEngine.Physics2D.SetLayerCollisionMask(layer, layerMask);
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Physics2D.SetLayerCollisionMask";
        public static string GetMenuPath() => "Physics2D/Function/SetLayerCollisionMask";
        public static string Signature() => " (layer,layerMask)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics2D);
    }
}
