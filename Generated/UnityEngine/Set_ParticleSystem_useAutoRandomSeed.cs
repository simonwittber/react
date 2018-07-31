using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Sets ParticleSystem.useAutoRandomSeed on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_ParticleSystem_useAutoRandomSeed : LeafNode
    {
        public bool value;

        protected ParticleSystem Component { get; set; }

        protected override NodeState Execute() {
            Component.useAutoRandomSeed = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<ParticleSystem>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET ParticleSystem.useAutoRandomSeed";
        public static string GetMenuPath() => "ParticleSystem/Set/useAutoRandomSeed";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(ParticleSystem);
    }
}
