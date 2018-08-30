using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Target_CanSeeTarget_range : LeafNode
    {
        public float range;

        protected DifferentMethods.React.Components.Target Component { get; set; }

        protected override NodeState Execute() {
            if(Component.CanSeeTarget(range)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Target>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Target.CanSeeTarget";
        public static string GetMenuPath() => "Target/Condition/CanSeeTarget";
        public static string Signature() => " (range)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Target);
    }

    
    [System.Serializable]
    public class Not_Condition_Target_CanSeeTarget_range : LeafNode
    {
        public float range;

        protected DifferentMethods.React.Components.Target Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.CanSeeTarget(range)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Target>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Target.CanSeeTarget";
        public static string GetMenuPath() => "Target/Condition/CanSeeTarget";
        public static string Signature() => " (range)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Target);
    }
}
