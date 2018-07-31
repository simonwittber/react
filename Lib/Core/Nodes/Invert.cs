using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{
    /// <summary>
    /// Invert and return the state of the child. Continue state is always returned as Continue.
    /// </summary>
    [System.Serializable]
    [CoreNode]
    public class Invert : DecoratorNode
    {
        protected override NodeState Execute()
        {
            if (Child != null)
            {
                var result = ExecuteNode(Child);
                switch (result)
                {
                    case NodeState.Failure:
                        return NodeState.Success;
                    case NodeState.Success:
                        return NodeState.Failure;
                }
                return result;
            }
            return NodeState.NoResult;
        }

        public static string GetMenuPath()
        {
            return "Invert _i";
        }
    }
}
