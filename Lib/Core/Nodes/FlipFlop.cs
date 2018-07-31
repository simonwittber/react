using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{
    /// <summary>
    /// Executes the child every other time this node is executed. Starting state can be set. 
    /// </summary>
    [System.Serializable]
    [CoreNode]
    public class FlipFlop : DecoratorNode
    {
        public bool state = false;

        protected override NodeState Execute()
        {
            state = !state;
            if (Child != null)
            {
                if (!state)
                {
                    return ExecuteNode(Child);
                }
            }
            return NodeState.NoResult;
        }
    }
}
