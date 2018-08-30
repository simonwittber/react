using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Transform_Rotate_eulers_relativeTo : LeafNode
    {
        public UnityEngine.Vector3 eulers;
        public UnityEngine.Space relativeTo;

        protected UnityEngine.Transform Component { get; set; }

        protected override NodeState Execute() {
            Component.Rotate(eulers, relativeTo);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Transform>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Transform.Rotate";
        public static string GetMenuPath() => "Transform/Function/Rotate/(eulers, relativeTo)";
        public static string Signature() => " (eulers,relativeTo)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Transform);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Transform), typeof(Function_Transform_Rotate_eulers_relativeTo));
    }
}
