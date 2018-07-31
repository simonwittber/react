using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of Target.CanSeeTarget on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Target_CanSeeTarget_range : DecoratorNode
    {
        public float range;

        protected DifferentMethods.React.Components.Target Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.CanSeeTarget(range)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Target>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Target.CanSeeTarget";
        public static string GetMenuPath() => "Target/If/CanSeeTarget";
        public static string Signature() => " (range)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Target);
    }
}
