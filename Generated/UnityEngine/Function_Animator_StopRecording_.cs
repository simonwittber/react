using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Animator_StopRecording_ : LeafNode
    {

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.StopRecording();
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Animator.StopRecording";
        public static string GetMenuPath() => "Animator/Function/StopRecording";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animator), typeof(Function_Animator_StopRecording_));
    }
}
