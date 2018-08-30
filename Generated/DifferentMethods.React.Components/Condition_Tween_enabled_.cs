using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Tween_enabled_ : LeafNode
    {

        protected DifferentMethods.React.Components.Tween Component { get; set; }

        protected override NodeState Execute() {
            if(Component.enabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Tween>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Tween.enabled";
        public static string GetMenuPath() => "Tween/Condition/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Tween);
    }

    
    [System.Serializable]
    public class Not_Condition_Tween_enabled_ : LeafNode
    {

        protected DifferentMethods.React.Components.Tween Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.enabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Tween>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Tween.enabled";
        public static string GetMenuPath() => "Tween/Condition/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Tween);
    }
}
