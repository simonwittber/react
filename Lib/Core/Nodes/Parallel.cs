using System;
using System.Collections;
using System.Collections.Generic;


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

        void Reset()
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
            while (true)
            {
                var state = NodeState.Continue;
                BaseNode child = null;
                while (running.Count > 0)
                {
                    child = running.Dequeue();
                    var result = ExecuteNode(child);
                    switch (result)
                    {
                        case NodeState.CallAgain:
                            state = NodeState.CallAgain;
                            pending.Enqueue(child);
                            continue;
                        case NodeState.Continue:
                            pending.Enqueue(child);
                            continue;
                        case NodeState.Failure:
                            if (policy == ParallelPolicy.FailIfOneFails)
                            {
                                state = NodeState.Failure;
                                break;
                            }
                            continue;
                        case NodeState.Success:
                            if (policy == ParallelPolicy.SucceedIfOneSucceeds)
                            {
                                state = NodeState.Success;
                                break;
                            }
                            continue;
                    }
                }

                switch (state)
                {
                    case NodeState.Success:
                    case NodeState.Failure:
                        AbortChildren(child);
                        Reset();
                        return state;
                    case NodeState.Continue:
                    case NodeState.CallAgain:
                        var T = running;
                        running = pending;
                        pending = T;
                        if (state == NodeState.Continue)
                        {
                            if (running.Count > 0)
                                continue;
                            else
                                Reset();
                        }

                        return state;
                }
            }
        }

    }

}




