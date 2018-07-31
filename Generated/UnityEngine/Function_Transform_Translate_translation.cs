using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes method call Transform.Translate on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Transform_Translate_translation : LeafNode
    {
        public UnityEngine.Vector3 translation;

        protected UnityEngine.Transform Component { get; set; }

        protected override NodeState Execute() {
            Component.Translate(translation);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Transform>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Transform.Translate";
        public static string GetMenuPath() => "Transform/Function/Translate/(translation)";
        public static string Signature() => " (translation)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Transform);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Transform), typeof(Function_Transform_Translate_translation));
    }
}
