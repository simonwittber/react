using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets Animator.layersAffectMassCenter on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Animator_layersAffectMassCenter : LeafNode
    {
        public bool value;

        protected Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.layersAffectMassCenter = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Animator>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Animator.layersAffectMassCenter";
        public static string GetMenuPath() => "Animator/Set/layersAffectMassCenter";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Animator);
    }
}
