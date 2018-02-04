using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{

    /// <summary>
    /// Execute all children until a child returns a success state.
    /// </summary>
    [System.Serializable]
    [CoreNode]
    public class Selector : BranchNode
    {

        protected override NodeState Execute()
        {
            while (true)
            {
                switch (ExecuteNode(ActiveChild))
                {

                    case NodeState.Failure:
                    case NodeState.Continue:
                        break;
                    case NodeState.Success:
                        return NodeState.Success;
                    case NodeState.CallAgain:
                        return NodeState.CallAgain;
                }
                if (NextChild())
                    continue;
                else
                    return NodeState.Failure;
            }
        }

        public static string GetMenuPath()
        {
            return "Selector _s";
        }
    }

}
