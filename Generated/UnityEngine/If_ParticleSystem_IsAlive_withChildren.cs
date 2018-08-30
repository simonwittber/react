using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class If_ParticleSystem_IsAlive_withChildren : DecoratorNode
    {
        public bool withChildren;

        protected UnityEngine.ParticleSystem Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.IsAlive(withChildren)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.ParticleSystem>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF ParticleSystem.IsAlive";
        public static string GetMenuPath() => "ParticleSystem/If/IsAlive/(withChildren)";
        public static string Signature() => " (withChildren)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.ParticleSystem);
    }

    
    [System.Serializable]
    public class Not_If_ParticleSystem_IsAlive_withChildren : DecoratorNode
    {
        public bool withChildren;

        protected UnityEngine.ParticleSystem Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.IsAlive(withChildren)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.ParticleSystem>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT ParticleSystem.IsAlive";
        public static string GetMenuPath() => "ParticleSystem/If/IsAlive/(withChildren)";
        public static string Signature() => " (withChildren)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.ParticleSystem);
    }
}
