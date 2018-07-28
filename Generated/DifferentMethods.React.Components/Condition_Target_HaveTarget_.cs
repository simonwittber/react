using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Target.HaveTarget on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Target_HaveTarget_ : LeafNode
    {


        DifferentMethods.React.Components.Target Component;

        protected override NodeState Execute() {
            if(Component.HaveTarget()) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = Reactor.GetComponent<DifferentMethods.React.Components.Target>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Target.HaveTarget";
        public static string GetMenuPath() => "Target/Condition/HaveTarget";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Target);
    }
}
