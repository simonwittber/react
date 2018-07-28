using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Target.TargetIsCloserThan on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Target_TargetIsCloserThan_distance : DecoratorNode
    {
        public float distance;


        protected DifferentMethods.React.Components.Target Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.TargetIsCloserThan(distance)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<DifferentMethods.React.Components.Target>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Target.TargetIsCloserThan";
        public static string GetMenuPath() => "Target/If/TargetIsCloserThan";
        public static string Signature() => " (distance)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Target);

    }
}
