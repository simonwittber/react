using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of Target.FindTargets on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Target_FindTargets_layer_range : DecoratorNode
    {
        public UnityEngine.LayerMask layer;
        public float range;

        protected DifferentMethods.React.Components.Target Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.FindTargets(layer, range)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Target>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Target.FindTargets";
        public static string GetMenuPath() => "Target/If/FindTargets";
        public static string Signature() => " (layer,range)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Target);
    }
}
