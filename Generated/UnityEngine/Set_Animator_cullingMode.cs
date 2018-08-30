using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Animator_cullingMode : LeafNode
    {
        public UnityEngine.AnimatorCullingMode value;

        protected Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.cullingMode = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Animator>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Animator.cullingMode";
        public static string GetMenuPath() => "Animator/Set/cullingMode";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Animator);
    }
}
