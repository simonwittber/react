using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{
    /// <summary>
    /// Ensures that the child is only executed once every X seconds, regardless of the number of times the graph is executed.
    /// </summary>
    [System.Serializable]
    [CoreNode]
    public class Cooldown : DecoratorNode
    {
        public bool scaledTime = true;
        public float seconds = 1;

        float lastCall = -1;

        protected override NodeState Execute()
        {
            if (Child == null)
                return NodeState.NoResult;

            var now = scaledTime ? Time.time : Time.unscaledTime;

            if ((now - lastCall) > seconds || lastCall < 0)
            {
                lastCall = scaledTime ? Time.time : Time.unscaledTime;
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }
    }
}
