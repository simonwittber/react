using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Target.TargetIsFurtherThan on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Target_TargetIsFurtherThan_distance : DecoratorNode
    {
        public float distance;


        DifferentMethods.React.Components.Target Component;

        protected override NodeState Execute() 
        {
            if(Component.TargetIsFurtherThan(distance)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = Reactor.GetComponent<DifferentMethods.React.Components.Target>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Target.TargetIsFurtherThan";
        public static string GetMenuPath() => "Target/If/TargetIsFurtherThan";
        public static string Signature() => " (distance)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Target);

    }
}
