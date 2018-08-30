using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Animator_IsInTransition_layerIndex : DecoratorNode
    {
        public int layerIndex;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.IsInTransition(layerIndex)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Animator.IsInTransition";
        public static string GetMenuPath() => "Animator/If/IsInTransition";
        public static string Signature() => " (layerIndex)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);
    }

    
    [System.Serializable]
    public class Not_If_Animator_IsInTransition_layerIndex : DecoratorNode
    {
        public int layerIndex;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.IsInTransition(layerIndex)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT Animator.IsInTransition";
        public static string GetMenuPath() => "Animator/If/IsInTransition";
        public static string Signature() => " (layerIndex)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);
    }
}
