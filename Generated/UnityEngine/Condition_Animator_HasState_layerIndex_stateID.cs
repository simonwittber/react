using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Animator_HasState_layerIndex_stateID : LeafNode
    {
        public int layerIndex;
        public int stateID;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            if(Component.HasState(layerIndex, stateID)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Animator.HasState";
        public static string GetMenuPath() => "Animator/Condition/HasState";
        public static string Signature() => " (layerIndex,stateID)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);
    }

    
    [System.Serializable]
    public class Not_Condition_Animator_HasState_layerIndex_stateID : LeafNode
    {
        public int layerIndex;
        public int stateID;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.HasState(layerIndex, stateID)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Animator.HasState";
        public static string GetMenuPath() => "Animator/Condition/HasState";
        public static string Signature() => " (layerIndex,stateID)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);
    }
}
