using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{

    public enum ParallelPolicy
    {
        FailIfOneFails,
        SucceedIfOneSucceeds
    }

    /// <summary>
    /// Executes all children simultaneously, returning when one fails or succeeds, depending on the policy setting.
	/// Any children still running when a failure or success occurs will be aborted.
    /// </summary>
    [System.Serializable]
    [CoreNode]
    public class Parallel : BranchNode
    {
        public ParallelPolicy policy;

        Queue<BaseNode> pending = new Queue<BaseNode>();
        Queue<BaseNode> running = new Queue<BaseNode>();
        bool inProgress = false;

        public void AbortChildren(BaseNode exclude)
        {
            for (var i = 0; i < Children.Count; i++)
            {
                var child = Children[i];
                if (child != exclude)
                    child.Abort();
            }
        }

        void Init()
        {
            running.Clear();
            for (var i = 0; i < Children.Count; i++)
                running.Enqueue(Children[i]);
            pending.Clear();
        }

        new void Reset()
        {
            inProgress = false;
            running.Clear();
            pending.Clear();
        }

        public override void Abort()
        {
            base.Abort();
            AbortChildren(null);
            Reset();
        }

        protected override NodeState Execute()
        {
            if (!inProgress)
            {
                inProgress = true;
                Init();
            }

            for (int i = 0, count = running.Count; i < count; i++)
            {
                var child = running.Dequeue();
                var state = ExecuteNode(child);
                switch (state)
                {
                    case NodeState.ContinueNextFrame:
                        running.Enqueue(child);
                        continue;
                    case NodeState.Failure:
                        if (policy == ParallelPolicy.FailIfOneFails)
                        {
                            AbortChildren(exclude: child);
                            return NodeState.Failure;
                        }
                        continue;
                    case NodeState.Success:
                        if (policy == ParallelPolicy.SucceedIfOneSucceeds)
                        {
                            AbortChildren(exclude: child);
                            return NodeState.Success;
                        }
                        continue;
                }
            }
            if (running.Count > 0)
                return NodeState.ContinueNextFrame;
            return NodeState.Success;
        }

    }

}




