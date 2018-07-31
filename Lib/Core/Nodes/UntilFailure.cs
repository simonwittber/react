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
                return NodeState.NoResult;
            var result = ExecuteNode(Child);
            switch (result)
            {
                case NodeState.Failure:
                    return NodeState.Failure;
                default:
                    return NodeState.ContinueNextFrame;
            }
        }

        public override string ToString() => "Until Failure";

        public static string GetMenuPath() => "Until/Failure";
    }

}
