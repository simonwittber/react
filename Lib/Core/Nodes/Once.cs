using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{
    /// <summary>
    /// This decorator will execute it's child once per gameObject.
    /// </summary>
    [System.Serializable]
    [CoreNode]
    public class Once : DecoratorNode
    {
        bool done = false;

        protected override NodeState Execute()
        {
            if (!done && Child != null)
            {
                var result = ExecuteNode(Child);
                if (result != NodeState.ContinueNextFrame)
                    done = true;
                return result;
            }
            return NodeState.NoResult;
        }
    }
}
