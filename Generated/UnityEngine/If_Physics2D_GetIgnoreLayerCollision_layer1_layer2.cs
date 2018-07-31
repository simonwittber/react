using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of Physics2D.GetIgnoreLayerCollision on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Physics2D_GetIgnoreLayerCollision_layer1_layer2 : DecoratorNode
    {
        public int layer1;
        public int layer2;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Physics2D.GetIgnoreLayerCollision(layer1, layer2)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics2D.GetIgnoreLayerCollision";
        public static string GetMenuPath() => "Physics2D/If/GetIgnoreLayerCollision";
        public static string Signature() => " (layer1,layer2)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics2D);
    }
}
