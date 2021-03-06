using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Transform_LookAt_target_worldUp : LeafNode
    {
        public UnityEngine.Transform target;
        public UnityEngine.Vector3 worldUp;

        protected UnityEngine.Transform Component { get; set; }

        protected override NodeState Execute() {
            Component.LookAt(target, worldUp);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Transform>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Transform.LookAt";
        public static string GetMenuPath() => "Transform/Function/LookAt/(target, worldUp)";
        public static string Signature() => " (target,worldUp)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Transform);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Transform), typeof(Function_Transform_LookAt_target_worldUp));
    }
}
