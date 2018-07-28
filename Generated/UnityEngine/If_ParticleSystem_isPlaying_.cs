using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of ParticleSystem.isPlaying on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_ParticleSystem_isPlaying_ : DecoratorNode
    {


        UnityEngine.ParticleSystem Component;

        protected override NodeState Execute() 
        {
            if(Component.isPlaying) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = Reactor.GetComponent<UnityEngine.ParticleSystem>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF ParticleSystem.isPlaying";
        public static string GetMenuPath() => "ParticleSystem/If/isPlaying";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.ParticleSystem);

    }
}