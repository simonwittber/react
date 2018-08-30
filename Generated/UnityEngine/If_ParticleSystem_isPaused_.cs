using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_ParticleSystem_isPaused_ : DecoratorNode
    {

        protected UnityEngine.ParticleSystem Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.isPaused) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.ParticleSystem>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF ParticleSystem.isPaused";
        public static string GetMenuPath() => "ParticleSystem/If/isPaused";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.ParticleSystem);
    }

    
    [System.Serializable]
    public class Not_If_ParticleSystem_isPaused_ : DecoratorNode
    {

        protected UnityEngine.ParticleSystem Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.isPaused) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.ParticleSystem>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT ParticleSystem.isPaused";
        public static string GetMenuPath() => "ParticleSystem/If/isPaused";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.ParticleSystem);
    }
}
