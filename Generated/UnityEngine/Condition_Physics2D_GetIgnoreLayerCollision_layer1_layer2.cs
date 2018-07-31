using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Physics2D.GetIgnoreLayerCollision on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Physics2D_GetIgnoreLayerCollision_layer1_layer2 : LeafNode
    {
        public int layer1;
        public int layer2;

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics2D.GetIgnoreLayerCollision(layer1, layer2))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Physics2D.GetIgnoreLayerCollision";
        public static string GetMenuPath() => "Physics2D/Condition/GetIgnoreLayerCollision";
        public static string Signature() => " (layer1,layer2)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics2D);
    }
}
