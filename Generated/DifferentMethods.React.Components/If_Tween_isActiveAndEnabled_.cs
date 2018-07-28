using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Tween.isActiveAndEnabled on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Tween_isActiveAndEnabled_ : DecoratorNode
    {


        DifferentMethods.React.Components.Tween Component;

        protected override NodeState Execute() 
        {
            if(Component.isActiveAndEnabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = Reactor.GetComponent<DifferentMethods.React.Components.Tween>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Tween.isActiveAndEnabled";
        public static string GetMenuPath() => "Tween/If/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Tween);

    }
}
