using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_ParticleSystem_isStopped_ : DecoratorNode
    {

        protected UnityEngine.ParticleSystem Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.isStopped) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.ParticleSystem>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF ParticleSystem.isStopped";
        public static string GetMenuPath() => "ParticleSystem/If/isStopped";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.ParticleSystem);
    }

    
    [System.Serializable]
    public class Not_If_ParticleSystem_isStopped_ : DecoratorNode
    {

        protected UnityEngine.ParticleSystem Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.isStopped) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.ParticleSystem>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT ParticleSystem.isStopped";
        public static string GetMenuPath() => "ParticleSystem/If/isStopped";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.ParticleSystem);
    }
}
