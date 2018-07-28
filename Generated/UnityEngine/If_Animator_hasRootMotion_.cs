using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Animator.hasRootMotion on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Animator_hasRootMotion_ : DecoratorNode
    {


        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.hasRootMotion) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Animator>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Animator.hasRootMotion";
        public static string GetMenuPath() => "Animator/If/hasRootMotion";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

    }
}
