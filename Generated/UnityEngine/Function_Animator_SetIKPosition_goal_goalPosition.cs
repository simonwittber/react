using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes method call Animator.SetIKPosition on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Animator_SetIKPosition_goal_goalPosition : LeafNode
    {
        public UnityEngine.AvatarIKGoal goal;
        public UnityEngine.Vector3 goalPosition;


        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.SetIKPosition(goal, goalPosition);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Animator>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Animator.SetIKPosition";
        public static string GetMenuPath() => "Animator/Function/SetIKPosition";
        public static string Signature() => " (goal,goalPosition)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animator), typeof(Function_Animator_SetIKPosition_goal_goalPosition));

    }
}
