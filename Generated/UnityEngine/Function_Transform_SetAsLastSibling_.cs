using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Transform_SetAsLastSibling_ : LeafNode
    {

        protected UnityEngine.Transform Component { get; set; }

        protected override NodeState Execute() {
            Component.SetAsLastSibling();
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Transform>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Transform.SetAsLastSibling";
        public static string GetMenuPath() => "Transform/Function/SetAsLastSibling";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Transform);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Transform), typeof(Function_Transform_SetAsLastSibling_));
    }
}
