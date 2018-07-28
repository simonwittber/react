using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of ParticleSystem.isStopped on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_ParticleSystem_isStopped_ : LeafNode
    {


        UnityEngine.ParticleSystem Component;

        protected override NodeState Execute() {
            if(Component.isStopped) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = Reactor.GetComponent<UnityEngine.ParticleSystem>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK ParticleSystem.isStopped";
        public static string GetMenuPath() => "ParticleSystem/Condition/isStopped";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.ParticleSystem);
    }
}
