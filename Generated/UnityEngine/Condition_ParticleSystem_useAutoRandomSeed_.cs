using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_ParticleSystem_useAutoRandomSeed_ : LeafNode
    {

        protected UnityEngine.ParticleSystem Component { get; set; }

        protected override NodeState Execute() {
            if(Component.useAutoRandomSeed) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.ParticleSystem>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK ParticleSystem.useAutoRandomSeed";
        public static string GetMenuPath() => "ParticleSystem/Condition/useAutoRandomSeed";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.ParticleSystem);
    }

    
    [System.Serializable]
    public class Not_Condition_ParticleSystem_useAutoRandomSeed_ : LeafNode
    {

        protected UnityEngine.ParticleSystem Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.useAutoRandomSeed) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.ParticleSystem>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT ParticleSystem.useAutoRandomSeed";
        public static string GetMenuPath() => "ParticleSystem/Condition/useAutoRandomSeed";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.ParticleSystem);
    }
}
