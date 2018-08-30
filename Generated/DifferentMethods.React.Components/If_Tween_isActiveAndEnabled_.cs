using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Tween_isActiveAndEnabled_ : DecoratorNode
    {

        protected DifferentMethods.React.Components.Tween Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.isActiveAndEnabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Tween>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Tween.isActiveAndEnabled";
        public static string GetMenuPath() => "Tween/If/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Tween);
    }

    
    [System.Serializable]
    public class Not_If_Tween_isActiveAndEnabled_ : DecoratorNode
    {

        protected DifferentMethods.React.Components.Tween Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.isActiveAndEnabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Tween>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT Tween.isActiveAndEnabled";
        public static string GetMenuPath() => "Tween/If/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Tween);
    }
}
