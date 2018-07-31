using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes method call Transform.SetAsFirstSibling on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Transform_SetAsFirstSibling_ : LeafNode
    {

        protected UnityEngine.Transform Component { get; set; }

        protected override NodeState Execute() {
            Component.SetAsFirstSibling();
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Transform>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Transform.SetAsFirstSibling";
        public static string GetMenuPath() => "Transform/Function/SetAsFirstSibling";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Transform);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Transform), typeof(Function_Transform_SetAsFirstSibling_));
    }
}
