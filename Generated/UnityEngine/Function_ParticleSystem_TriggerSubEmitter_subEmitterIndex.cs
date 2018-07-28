using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call ParticleSystem.TriggerSubEmitter on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_ParticleSystem_TriggerSubEmitter_subEmitterIndex : LeafNode
    {
        public int subEmitterIndex;


        protected UnityEngine.ParticleSystem Component { get; set; }

        protected override NodeState Execute() {
            Component.TriggerSubEmitter(subEmitterIndex);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.ParticleSystem>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "ParticleSystem.TriggerSubEmitter";
        public static string GetMenuPath() => "ParticleSystem/Function/TriggerSubEmitter/(subEmitterIndex)";
        public static string Signature() => " (subEmitterIndex)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.ParticleSystem);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.ParticleSystem), typeof(Function_ParticleSystem_TriggerSubEmitter_subEmitterIndex));

    }
}
