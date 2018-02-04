using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{

    /// <summary>
    /// Tries to executes child until a failure state is received.
    /// </summary>
    [System.Serializable]
    [CoreNode]
    public class UntilFailure : DecoratorNode
    {

        protected override NodeState Execute()
        {
            if (Child == null)
                return NodeState.Continue;

            var result = ExecuteNode(Child);
            if (result == NodeState.Failure)
                return result;
            else
                return NodeState.CallAgain;
        }

        public override string ToString()
        {
            return "Until Failure";
        }

        public static string GetMenuPath()
        {
            return "Until/Failure";
        }
    }

}
