using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call ParticleSystem.Clear on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_ParticleSystem_Clear_withChildren : LeafNode
    {
        public bool withChildren;


        UnityEngine.ParticleSystem Component;

        protected override NodeState Execute() {
            Component.Clear(withChildren);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = Reactor.GetComponent<UnityEngine.ParticleSystem>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "ParticleSystem.Clear";
        public static string GetMenuPath() => "ParticleSystem/Function/Clear/(withChildren)";
        public static string Signature() => " (withChildren)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.ParticleSystem);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.ParticleSystem), typeof(Function_ParticleSystem_Clear_withChildren));

    }
}
