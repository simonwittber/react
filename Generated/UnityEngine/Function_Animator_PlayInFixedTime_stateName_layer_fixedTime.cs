using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Animator_PlayInFixedTime_stateName_layer_fixedTime : LeafNode
    {
        public string stateName;
        public int layer;
        public float fixedTime;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.PlayInFixedTime(stateName, layer, fixedTime);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Animator.PlayInFixedTime";
        public static string GetMenuPath() => "Animator/Function/PlayInFixedTime/(stateName, layer, fixedTime)";
        public static string Signature() => " (stateName,layer,fixedTime)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animator), typeof(Function_Animator_PlayInFixedTime_stateName_layer_fixedTime));
    }
}
