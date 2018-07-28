using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call Animation.SyncLayer on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Animation_SyncLayer_layer : LeafNode
    {
        public int layer;


        protected UnityEngine.Animation Component { get; set; }

        protected override NodeState Execute() {
            Component.SyncLayer(layer);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Animation>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Animation.SyncLayer";
        public static string GetMenuPath() => "Animation/Function/SyncLayer";
        public static string Signature() => " (layer)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animation);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animation), typeof(Function_Animation_SyncLayer_layer));

    }
}
