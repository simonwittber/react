using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of Physics.GetIgnoreLayerCollision on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Physics_GetIgnoreLayerCollision_layer1_layer2 : DecoratorNode
    {
        public int layer1;
        public int layer2;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Physics.GetIgnoreLayerCollision(layer1, layer2)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics.GetIgnoreLayerCollision";
        public static string GetMenuPath() => "Physics/If/GetIgnoreLayerCollision";
        public static string Signature() => " (layer1,layer2)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
