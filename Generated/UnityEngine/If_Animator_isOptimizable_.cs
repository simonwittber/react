using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Animator_isOptimizable_ : DecoratorNode
    {

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.isOptimizable) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Animator.isOptimizable";
        public static string GetMenuPath() => "Animator/If/isOptimizable";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);
    }

    
    [System.Serializable]
    public class Not_If_Animator_isOptimizable_ : DecoratorNode
    {

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.isOptimizable) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT Animator.isOptimizable";
        public static string GetMenuPath() => "Animator/If/isOptimizable";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);
    }
}
