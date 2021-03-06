using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    [System.Serializable]
    
    public class Function_Physics_IgnoreLayerCollision_layer1_layer2 : LeafNode
    {
        public int layer1;
        public int layer2;

        
        protected override NodeState Execute() {
            UnityEngine.Physics.IgnoreLayerCollision(layer1, layer2);
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Physics.IgnoreLayerCollision";
        public static string GetMenuPath() => "Physics/Function/IgnoreLayerCollision/(layer1, layer2)";
        public static string Signature() => " (layer1,layer2)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
