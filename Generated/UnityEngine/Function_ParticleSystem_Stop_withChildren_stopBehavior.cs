using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_ParticleSystem_Stop_withChildren_stopBehavior : LeafNode
    {
        public bool withChildren;
        public UnityEngine.ParticleSystemStopBehavior stopBehavior;

        protected UnityEngine.ParticleSystem Component { get; set; }

        protected override NodeState Execute() {
            Component.Stop(withChildren, stopBehavior);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.ParticleSystem>();
        public override string ToString() => NiceName();
        public static string NiceName() => "ParticleSystem.Stop";
        public static string GetMenuPath() => "ParticleSystem/Function/Stop/(withChildren, stopBehavior)";
        public static string Signature() => " (withChildren,stopBehavior)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.ParticleSystem);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.ParticleSystem), typeof(Function_ParticleSystem_Stop_withChildren_stopBehavior));
    }
}
