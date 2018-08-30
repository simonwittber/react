using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Animator_IsParameterControlledByCurve_name : LeafNode
    {
        public string id;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            if(Component.IsParameterControlledByCurve(id)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Animator.IsParameterControlledByCurve";
        public static string GetMenuPath() => "Animator/Condition/IsParameterControlledByCurve/(name)";
        public static string Signature() => " (name)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);
    }

    
    [System.Serializable]
    public class Not_Condition_Animator_IsParameterControlledByCurve_name : LeafNode
    {
        public string id;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.IsParameterControlledByCurve(id)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Animator.IsParameterControlledByCurve";
        public static string GetMenuPath() => "Animator/Condition/IsParameterControlledByCurve/(name)";
        public static string Signature() => " (name)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);
    }
}
