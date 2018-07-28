using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of ParticleSystem.isEmitting on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_ParticleSystem_isEmitting_ : DecoratorNode
    {


        UnityEngine.ParticleSystem Component;

        protected override NodeState Execute() 
        {
            if(Component.isEmitting) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = Reactor.GetComponent<UnityEngine.ParticleSystem>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF ParticleSystem.isEmitting";
        public static string GetMenuPath() => "ParticleSystem/If/isEmitting";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.ParticleSystem);

    }
}
