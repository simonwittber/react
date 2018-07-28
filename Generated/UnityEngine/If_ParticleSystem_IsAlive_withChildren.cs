using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of ParticleSystem.IsAlive on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_ParticleSystem_IsAlive_withChildren : DecoratorNode
    {
        public bool withChildren;


        UnityEngine.ParticleSystem Component;

        protected override NodeState Execute() 
        {
            if(Component.IsAlive(withChildren)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = Reactor.GetComponent<UnityEngine.ParticleSystem>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF ParticleSystem.IsAlive";
        public static string GetMenuPath() => "ParticleSystem/If/IsAlive/(withChildren)";
        public static string Signature() => " (withChildren)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.ParticleSystem);

    }
}
