using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Navigation.isActiveAndEnabled on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Navigation_isActiveAndEnabled_ : LeafNode
    {

        protected DifferentMethods.React.Components.Navigation Component { get; set; }

        protected override NodeState Execute() {
            if(Component.isActiveAndEnabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Navigation>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Navigation.isActiveAndEnabled";
        public static string GetMenuPath() => "Navigation/Condition/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Navigation);
    }
}
