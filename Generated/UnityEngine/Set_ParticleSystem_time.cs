using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets ParticleSystem.time on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_ParticleSystem_time : LeafNode
    {
        public float value;

        ParticleSystem Component;

        protected override NodeState Execute() {
            Component.time = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = Reactor.GetComponent<ParticleSystem>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET ParticleSystem.time";
        public static string GetMenuPath() => "ParticleSystem/Set/time";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(ParticleSystem);
    }
}
