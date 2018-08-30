using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Animation_Rewind_ : LeafNode
    {

        protected UnityEngine.Animation Component { get; set; }

        protected override NodeState Execute() {
            Component.Rewind();
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animation>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Animation.Rewind";
        public static string GetMenuPath() => "Animation/Function/Rewind";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animation);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animation), typeof(Function_Animation_Rewind_));
    }
}
