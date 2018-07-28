using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes method call Animator.SetLookAtPosition on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Animator_SetLookAtPosition_lookAtPosition : LeafNode
    {
        public UnityEngine.Vector3 lookAtPosition;


        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.SetLookAtPosition(lookAtPosition);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Animator>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Animator.SetLookAtPosition";
        public static string GetMenuPath() => "Animator/Function/SetLookAtPosition";
        public static string Signature() => " (lookAtPosition)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animator), typeof(Function_Animator_SetLookAtPosition_lookAtPosition));

    }
}
