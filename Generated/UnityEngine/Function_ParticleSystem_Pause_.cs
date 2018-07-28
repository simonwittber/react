using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes method call ParticleSystem.Pause on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_ParticleSystem_Pause_ : LeafNode
    {


        UnityEngine.ParticleSystem Component;

        protected override NodeState Execute() {
            Component.Pause();
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = Reactor.GetComponent<UnityEngine.ParticleSystem>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "ParticleSystem.Pause";
        public static string GetMenuPath() => "ParticleSystem/Function/Pause";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.ParticleSystem);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.ParticleSystem), typeof(Function_ParticleSystem_Pause_));

    }
}
