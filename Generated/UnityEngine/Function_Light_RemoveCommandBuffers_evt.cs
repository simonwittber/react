using DifferentMethods.React;
using UnityEngine;
using UnityEngine.Rendering;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Light_RemoveCommandBuffers_evt : LeafNode
    {
        public UnityEngine.Rendering.LightEvent evt;

        protected UnityEngine.Light Component { get; set; }

        protected override NodeState Execute() {
            Component.RemoveCommandBuffers(evt);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Light>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Light.RemoveCommandBuffers";
        public static string GetMenuPath() => "Light/Function/RemoveCommandBuffers";
        public static string Signature() => " (evt)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Light);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Light), typeof(Function_Light_RemoveCommandBuffers_evt));
    }
}
