using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes method call Animator.PlayInFixedTime on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Animator_PlayInFixedTime_stateNameHash_layer : LeafNode
    {
        public int stateNameHash;
        public int layer;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.PlayInFixedTime(stateNameHash, layer);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Animator.PlayInFixedTime";
        public static string GetMenuPath() => "Animator/Function/PlayInFixedTime/(stateNameHash, layer)";
        public static string Signature() => " (stateNameHash,layer)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animator), typeof(Function_Animator_PlayInFixedTime_stateNameHash_layer));
    }
}
