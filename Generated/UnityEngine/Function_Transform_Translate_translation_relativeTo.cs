using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Transform_Translate_translation_relativeTo : LeafNode
    {
        public UnityEngine.Vector3 translation;
        public UnityEngine.Transform relativeTo;

        protected UnityEngine.Transform Component { get; set; }

        protected override NodeState Execute() {
            Component.Translate(translation, relativeTo);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Transform>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Transform.Translate";
        public static string GetMenuPath() => "Transform/Function/Translate/(translation, relativeTo)";
        public static string Signature() => " (translation,relativeTo)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Transform);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Transform), typeof(Function_Transform_Translate_translation_relativeTo));
    }
}
