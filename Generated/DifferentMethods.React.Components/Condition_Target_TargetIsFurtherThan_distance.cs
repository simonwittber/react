using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Target.TargetIsFurtherThan on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Target_TargetIsFurtherThan_distance : LeafNode
    {
        public float distance;


        DifferentMethods.React.Components.Target Component;

        protected override NodeState Execute() {
            if(Component.TargetIsFurtherThan(distance)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = Reactor.GetComponent<DifferentMethods.React.Components.Target>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Target.TargetIsFurtherThan";
        public static string GetMenuPath() => "Target/Condition/TargetIsFurtherThan";
        public static string Signature() => " (distance)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Target);
    }
}
