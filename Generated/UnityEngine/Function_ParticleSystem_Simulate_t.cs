using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call ParticleSystem.Simulate on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_ParticleSystem_Simulate_t : LeafNode
    {
        public float t;


        protected UnityEngine.ParticleSystem Component { get; set; }

        protected override NodeState Execute() {
            Component.Simulate(t);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.ParticleSystem>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "ParticleSystem.Simulate";
        public static string GetMenuPath() => "ParticleSystem/Function/Simulate/(t)";
        public static string Signature() => " (t)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.ParticleSystem);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.ParticleSystem), typeof(Function_ParticleSystem_Simulate_t));

    }
}
