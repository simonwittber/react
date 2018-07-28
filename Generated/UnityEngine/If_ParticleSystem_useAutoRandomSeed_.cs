using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of ParticleSystem.useAutoRandomSeed on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_ParticleSystem_useAutoRandomSeed_ : DecoratorNode
    {


        protected UnityEngine.ParticleSystem Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.useAutoRandomSeed) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.ParticleSystem>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF ParticleSystem.useAutoRandomSeed";
        public static string GetMenuPath() => "ParticleSystem/If/useAutoRandomSeed";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.ParticleSystem);

    }
}
