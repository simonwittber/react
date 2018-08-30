using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Camera_Render_ : LeafNode
    {

        protected UnityEngine.Camera Component { get; set; }

        protected override NodeState Execute() {
            Component.Render();
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Camera>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Camera.Render";
        public static string GetMenuPath() => "Camera/Function/Render";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Camera);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Camera), typeof(Function_Camera_Render_));
    }
}
