using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call ParticleSystem.Play on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_ParticleSystem_Play_withChildren : LeafNode
    {
        public bool withChildren;


        protected UnityEngine.ParticleSystem Component { get; set; }

        protected override NodeState Execute() {
            Component.Play(withChildren);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.ParticleSystem>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "ParticleSystem.Play";
        public static string GetMenuPath() => "ParticleSystem/Function/Play/(withChildren)";
        public static string Signature() => " (withChildren)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.ParticleSystem);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.ParticleSystem), typeof(Function_ParticleSystem_Play_withChildren));

    }
}
