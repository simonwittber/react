using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call Animator.StartRecording on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Animator_StartRecording_frameCount : LeafNode
    {
        public int frameCount;


        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.StartRecording(frameCount);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Animator>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Animator.StartRecording";
        public static string GetMenuPath() => "Animator/Function/StartRecording";
        public static string Signature() => " (frameCount)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animator), typeof(Function_Animator_StartRecording_frameCount));

    }
}
