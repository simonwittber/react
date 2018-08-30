using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Animation_clip : LeafNode
    {
        public UnityEngine.AnimationClip value;

        protected Animation Component { get; set; }

        protected override NodeState Execute() {
            Component.clip = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Animation>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Animation.clip";
        public static string GetMenuPath() => "Animation/Set/clip";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Animation);
    }
}
