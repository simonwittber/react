using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes method call Animator.SetIKHintPosition on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Animator_SetIKHintPosition_hint_hintPosition : LeafNode
    {
        public UnityEngine.AvatarIKHint hint;
        public UnityEngine.Vector3 hintPosition;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.SetIKHintPosition(hint, hintPosition);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Animator.SetIKHintPosition";
        public static string GetMenuPath() => "Animator/Function/SetIKHintPosition";
        public static string Signature() => " (hint,hintPosition)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animator), typeof(Function_Animator_SetIKHintPosition_hint_hintPosition));
    }
}
