using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of Animator.layersAffectMassCenter on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Animator_layersAffectMassCenter_ : DecoratorNode
    {

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.layersAffectMassCenter) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Animator.layersAffectMassCenter";
        public static string GetMenuPath() => "Animator/If/layersAffectMassCenter";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);
    }
}
