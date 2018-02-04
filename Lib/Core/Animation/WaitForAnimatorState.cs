using UnityEngine;

namespace DifferentMethods.React
{
    [System.Serializable]
    [CoreNode]
    public class WaitForAnimatorState : LeafNode
    {
        public Animator animator;
        public string stateName = "";
        public int layer = 0;

        int state;

        public override void OnEnable()
        {
            base.OnEnable();
            if (animator == null) animator = Reactor.GetComponent<Animator>();
            if (animator != null)
            {
                if (!animator.HasState(layer, state))
                {
                    Debug.LogError("The animator does not have state: " + stateName);
                    animator = null;
                }
                else
                    state = Animator.StringToHash(stateName);
            }
        }

        protected override NodeState Execute()
        {
            if (animator == null)
                return NodeState.Failure;
            var s = animator.GetCurrentAnimatorStateInfo(layer);
            if (s.shortNameHash == state || s.fullPathHash == state)
                return NodeState.Success;
            return NodeState.Continue;
        }

    }
}
