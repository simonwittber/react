using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Tween.isActiveAndEnabled on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Tween_isActiveAndEnabled_ : LeafNode
    {


        protected DifferentMethods.React.Components.Tween Component { get; set; }

        protected override NodeState Execute() {
            if(Component.isActiveAndEnabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<DifferentMethods.React.Components.Tween>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Tween.isActiveAndEnabled";
        public static string GetMenuPath() => "Tween/Condition/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Tween);
    }
}
