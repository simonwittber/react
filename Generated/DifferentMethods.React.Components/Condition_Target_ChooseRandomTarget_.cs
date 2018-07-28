using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Target.ChooseRandomTarget on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Target_ChooseRandomTarget_ : LeafNode
    {


        protected DifferentMethods.React.Components.Target Component { get; set; }

        protected override NodeState Execute() {
            if(Component.ChooseRandomTarget()) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<DifferentMethods.React.Components.Target>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Target.ChooseRandomTarget";
        public static string GetMenuPath() => "Target/Condition/ChooseRandomTarget";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Target);
    }
}
