using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Target.FindTargets on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Target_FindTargets_tag_range : DecoratorNode
    {
        public string tag;
        public float range;


        DifferentMethods.React.Components.Target Component;

        protected override NodeState Execute() 
        {
            if(Component.FindTargets(tag, range)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = Reactor.GetComponent<DifferentMethods.React.Components.Target>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Target.FindTargets";
        public static string GetMenuPath() => "Target/If/FindTargets";
        public static string Signature() => " (tag,range)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Target);

    }
}
