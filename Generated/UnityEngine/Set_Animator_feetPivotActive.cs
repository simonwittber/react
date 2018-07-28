using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets Animator.feetPivotActive on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Animator_feetPivotActive : LeafNode
    {
        public float value;

        protected Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.feetPivotActive = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Animator>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Animator.feetPivotActive";
        public static string GetMenuPath() => "Animator/Set/feetPivotActive";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Animator);
    }
}
