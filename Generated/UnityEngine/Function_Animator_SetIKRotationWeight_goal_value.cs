using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes method call Animator.SetIKRotationWeight on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Animator_SetIKRotationWeight_goal_value : LeafNode
    {
        public UnityEngine.AvatarIKGoal goal;
        public float value;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.SetIKRotationWeight(goal, value);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Animator.SetIKRotationWeight";
        public static string GetMenuPath() => "Animator/Function/SetIKRotationWeight";
        public static string Signature() => " (goal,value)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animator), typeof(Function_Animator_SetIKRotationWeight_goal_value));
    }
}
