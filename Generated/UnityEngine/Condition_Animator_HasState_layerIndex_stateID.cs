using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Animator.HasState on the active gameObject.
    /// </summary>
    
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

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<UnityEngine.Animator>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Animator.HasState";
        public static string GetMenuPath() => "Animator/Condition/HasState";
        public static string Signature() => " (layerIndex,stateID)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);
    }
}
