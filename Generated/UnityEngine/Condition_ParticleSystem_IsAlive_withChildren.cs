using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_ParticleSystem_IsAlive_withChildren : LeafNode
    {
        public bool withChildren;

        protected UnityEngine.ParticleSystem Component { get; set; }

        protected override NodeState Execute() {
            if(Component.IsAlive(withChildren)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.ParticleSystem>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK ParticleSystem.IsAlive";
        public static string GetMenuPath() => "ParticleSystem/Condition/IsAlive/(withChildren)";
        public static string Signature() => " (withChildren)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.ParticleSystem);
    }

    
    [System.Serializable]
    public class Not_Condition_ParticleSystem_IsAlive_withChildren : LeafNode
    {
        public bool withChildren;

        protected UnityEngine.ParticleSystem Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.IsAlive(withChildren)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.ParticleSystem>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT ParticleSystem.IsAlive";
        public static string GetMenuPath() => "ParticleSystem/Condition/IsAlive/(withChildren)";
        public static string Signature() => " (withChildren)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.ParticleSystem);
    }
}
