using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Physics_GetIgnoreLayerCollision_layer1_layer2 : LeafNode
    {
        public int layer1;
        public int layer2;

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics.GetIgnoreLayerCollision(layer1, layer2))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Physics.GetIgnoreLayerCollision";
        public static string GetMenuPath() => "Physics/Condition/GetIgnoreLayerCollision";
        public static string Signature() => " (layer1,layer2)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }

    
    [System.Serializable]
    public class Not_Condition_Physics_GetIgnoreLayerCollision_layer1_layer2 : LeafNode
    {
        public int layer1;
        public int layer2;

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics.GetIgnoreLayerCollision(layer1, layer2))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Physics.GetIgnoreLayerCollision";
        public static string GetMenuPath() => "Physics/Condition/GetIgnoreLayerCollision";
        public static string Signature() => " (layer1,layer2)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
