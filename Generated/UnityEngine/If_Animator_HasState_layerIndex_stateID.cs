using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Animator_HasState_layerIndex_stateID : DecoratorNode
    {
        public int layerIndex;
        public int stateID;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.HasState(layerIndex, stateID)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Animator.HasState";
        public static string GetMenuPath() => "Animator/If/HasState";
        public static string Signature() => " (layerIndex,stateID)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);
    }

    
    [System.Serializable]
    public class Not_If_Animator_HasState_layerIndex_stateID : DecoratorNode
    {
        public int layerIndex;
        public int stateID;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.HasState(layerIndex, stateID)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT Animator.HasState";
        public static string GetMenuPath() => "Animator/If/HasState";
        public static string Signature() => " (layerIndex,stateID)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);
    }
}
