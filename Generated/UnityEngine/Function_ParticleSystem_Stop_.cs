using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes method call ParticleSystem.Stop on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_ParticleSystem_Stop_ : LeafNode
    {


        UnityEngine.ParticleSystem Component;

        protected override NodeState Execute() {
            Component.Stop();
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = Reactor.GetComponent<UnityEngine.ParticleSystem>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "ParticleSystem.Stop";
        public static string GetMenuPath() => "ParticleSystem/Function/Stop";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.ParticleSystem);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.ParticleSystem), typeof(Function_ParticleSystem_Stop_));

    }
}
