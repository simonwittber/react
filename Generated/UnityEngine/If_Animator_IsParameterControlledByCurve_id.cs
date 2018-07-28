using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Animator.IsParameterControlledByCurve on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Animator_IsParameterControlledByCurve_id : DecoratorNode
    {
        public int id;


        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.IsParameterControlledByCurve(id)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Animator>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Animator.IsParameterControlledByCurve";
        public static string GetMenuPath() => "Animator/If/IsParameterControlledByCurve/(id)";
        public static string Signature() => " (id)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

    }
}
