using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Target_TargetIsCloserThan_distance : LeafNode
    {
        public float distance;

        protected DifferentMethods.React.Components.Target Component { get; set; }

        protected override NodeState Execute() {
            if(Component.TargetIsCloserThan(distance)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Target>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Target.TargetIsCloserThan";
        public static string GetMenuPath() => "Target/Condition/TargetIsCloserThan";
        public static string Signature() => " (distance)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Target);
    }

    
    [System.Serializable]
    public class Not_Condition_Target_TargetIsCloserThan_distance : LeafNode
    {
        public float distance;

        protected DifferentMethods.React.Components.Target Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.TargetIsCloserThan(distance)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Target>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Target.TargetIsCloserThan";
        public static string GetMenuPath() => "Target/Condition/TargetIsCloserThan";
        public static string Signature() => " (distance)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Target);
    }
}
