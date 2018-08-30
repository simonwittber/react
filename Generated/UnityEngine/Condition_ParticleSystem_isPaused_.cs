using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_ParticleSystem_isPaused_ : LeafNode
    {

        protected UnityEngine.ParticleSystem Component { get; set; }

        protected override NodeState Execute() {
            if(Component.isPaused) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.ParticleSystem>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK ParticleSystem.isPaused";
        public static string GetMenuPath() => "ParticleSystem/Condition/isPaused";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.ParticleSystem);
    }

    
    [System.Serializable]
    public class Not_Condition_ParticleSystem_isPaused_ : LeafNode
    {

        protected UnityEngine.ParticleSystem Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.isPaused) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.ParticleSystem>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT ParticleSystem.isPaused";
        public static string GetMenuPath() => "ParticleSystem/Condition/isPaused";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.ParticleSystem);
    }
}
