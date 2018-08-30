using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Light_RemoveAllCommandBuffers_ : LeafNode
    {

        protected UnityEngine.Light Component { get; set; }

        protected override NodeState Execute() {
            Component.RemoveAllCommandBuffers();
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Light>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Light.RemoveAllCommandBuffers";
        public static string GetMenuPath() => "Light/Function/RemoveAllCommandBuffers";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Light);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Light), typeof(Function_Light_RemoveAllCommandBuffers_));
    }
}
