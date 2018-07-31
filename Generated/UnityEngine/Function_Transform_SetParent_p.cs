using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes method call Transform.SetParent on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Transform_SetParent_p : LeafNode
    {
        public UnityEngine.Transform p;

        protected UnityEngine.Transform Component { get; set; }

        protected override NodeState Execute() {
            Component.SetParent(p);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Transform>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Transform.SetParent";
        public static string GetMenuPath() => "Transform/Function/SetParent/(p)";
        public static string Signature() => " (p)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Transform);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Transform), typeof(Function_Transform_SetParent_p));
    }
}
