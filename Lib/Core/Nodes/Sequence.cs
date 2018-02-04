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
                    case NodeState.Continue:
                        break;
                    case NodeState.Failure:
                        return NodeState.Failure;
                    case NodeState.CallAgain:
                        return NodeState.CallAgain;
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
