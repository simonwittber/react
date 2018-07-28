using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Target.FindTargets on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Target_FindTargets_tag_range : LeafNode
    {
        public string tag;
        public float range;


        DifferentMethods.React.Components.Target Component;

        protected override NodeState Execute() {
            if(Component.FindTargets(tag, range)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = Reactor.GetComponent<DifferentMethods.React.Components.Target>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Target.FindTargets";
        public static string GetMenuPath() => "Target/Condition/FindTargets";
        public static string Signature() => " (tag,range)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Target);
    }
}