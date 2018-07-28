using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Tween.enabled on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Tween_enabled_ : LeafNode
    {


        DifferentMethods.React.Components.Tween Component;

        protected override NodeState Execute() {
            if(Component.enabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = Reactor.GetComponent<DifferentMethods.React.Components.Tween>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Tween.enabled";
        public static string GetMenuPath() => "Tween/Condition/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Tween);
    }
}
