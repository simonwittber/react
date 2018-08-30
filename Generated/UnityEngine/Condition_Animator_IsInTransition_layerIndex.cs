using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Animator_IsInTransition_layerIndex : LeafNode
    {
        public int layerIndex;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            if(Component.IsInTransition(layerIndex)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Animator.IsInTransition";
        public static string GetMenuPath() => "Animator/Condition/IsInTransition";
        public static string Signature() => " (layerIndex)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);
    }

    
    [System.Serializable]
    public class Not_Condition_Animator_IsInTransition_layerIndex : LeafNode
    {
        public int layerIndex;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.IsInTransition(layerIndex)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Animator.IsInTransition";
        public static string GetMenuPath() => "Animator/Condition/IsInTransition";
        public static string Signature() => " (layerIndex)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);
    }
}
