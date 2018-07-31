using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of Tween.enabled on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Tween_enabled_ : DecoratorNode
    {

        protected DifferentMethods.React.Components.Tween Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.enabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Tween>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Tween.enabled";
        public static string GetMenuPath() => "Tween/If/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Tween);
    }
}
