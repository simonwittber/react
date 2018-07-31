using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of Target.HaveTarget on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Target_HaveTarget_ : DecoratorNode
    {

        protected DifferentMethods.React.Components.Target Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.HaveTarget()) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Target>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Target.HaveTarget";
        public static string GetMenuPath() => "Target/If/HaveTarget";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Target);
    }
}
