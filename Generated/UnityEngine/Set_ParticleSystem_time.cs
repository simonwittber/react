using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_ParticleSystem_time : LeafNode
    {
        public float value;

        protected ParticleSystem Component { get; set; }

        protected override NodeState Execute() {
            Component.time = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<ParticleSystem>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET ParticleSystem.time";
        public static string GetMenuPath() => "ParticleSystem/Set/time";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(ParticleSystem);
    }
}
