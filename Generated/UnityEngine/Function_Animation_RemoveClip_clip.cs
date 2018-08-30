using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Animation_RemoveClip_clip : LeafNode
    {
        public UnityEngine.AnimationClip clip;

        protected UnityEngine.Animation Component { get; set; }

        protected override NodeState Execute() {
            Component.RemoveClip(clip);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animation>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Animation.RemoveClip";
        public static string GetMenuPath() => "Animation/Function/RemoveClip/(clip)";
        public static string Signature() => " (clip)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animation);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animation), typeof(Function_Animation_RemoveClip_clip));
    }
}
