using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Animation_wrapMode : LeafNode
    {
        public UnityEngine.WrapMode value;

        protected Animation Component { get; set; }

        protected override NodeState Execute() {
            Component.wrapMode = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Animation>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Animation.wrapMode";
        public static string GetMenuPath() => "Animation/Set/wrapMode";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Animation);
    }
}
