using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{

    /// <summary>
    /// Execute all children until one returns a failure.
    /// </summary>
    [System.Serializable]
    [CoreNode]
    public class Sequence : BranchNode
    {
        protected override NodeState Execute()
        {
            while (true)
            {
                switch (ExecuteNode(ActiveChild))
                {
                    case NodeState.Success:
                    case NodeState.NoResult:
                        break;
                    case NodeState.Failure:
                        Reset();
                        return NodeState.Failure;
                    case NodeState.ContinueNextFrame:
                        return NodeState.ContinueNextFrame;
                }
                if (NextChild())
                    continue;
                else
                    return NodeState.Success;
            }
        }

        public static string GetMenuPath()
        {
            return "Sequence _q";
        }
    }

}
