using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Animator.IsParameterControlledByCurve on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Animator_IsParameterControlledByCurve_id : LeafNode
    {
        public int id;


        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            if(Component.IsParameterControlledByCurve(id)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<UnityEngine.Animator>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Animator.IsParameterControlledByCurve";
        public static string GetMenuPath() => "Animator/Condition/IsParameterControlledByCurve/(id)";
        public static string Signature() => " (id)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);
    }
}
