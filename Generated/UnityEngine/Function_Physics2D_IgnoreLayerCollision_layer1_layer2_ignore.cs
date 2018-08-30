using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    [System.Serializable]
    
    public class Function_Physics2D_IgnoreLayerCollision_layer1_layer2_ignore : LeafNode
    {
        public int layer1;
        public int layer2;
        public bool ignore;

        
        protected override NodeState Execute() {
            UnityEngine.Physics2D.IgnoreLayerCollision(layer1, layer2, ignore);
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Physics2D.IgnoreLayerCollision";
        public static string GetMenuPath() => "Physics2D/Function/IgnoreLayerCollision/(layer1, layer2, ignore)";
        public static string Signature() => " (layer1,layer2,ignore)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics2D);
    }
}
